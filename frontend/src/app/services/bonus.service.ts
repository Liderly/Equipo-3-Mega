import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom, map, Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { BonusListResponse, Technitian } from '../interfaces/techniciansListResponse.interface';



@Injectable({
  providedIn: 'root'
})
export class BonusService {

  private apiUrl = `${environment.apiUrl}/Report`;

  constructor(private http: HttpClient) { }

  GetBonusReport(NumPage:number,NumTec?:number): Observable<BonusListResponse> {
    if (NumTec == undefined){
      const url = `${this.apiUrl}?PageNumber=${NumPage}&PageSize=10`;
      return this.http.get<BonusListResponse>(url);

    }else{
      const url = `${this.apiUrl}?PageNumber=${NumPage}&PageSize=10&NumTec=${NumTec}`;
      return this.http.get<BonusListResponse>(url);
    }
  }
  GetAllReports(): Promise<Technitian[]> {
    const url = `${this.apiUrl}/All`;
    return firstValueFrom(this.http.get<BonusListResponse>(url).pipe(
      map((response: BonusListResponse) => response.technitians)
    ));
  }

}
