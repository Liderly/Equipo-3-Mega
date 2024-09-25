import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TasksService {

  private apiUrl = `${environment.apiUrl}/Tasks`;

  constructor(private http: HttpClient) { }

  getTask(): Observable<any> {
    console.log(this.apiUrl);
    return this.http.get<any>(this.apiUrl);
  }
  printUrl() {
    console.log(this.apiUrl);
  }
}
