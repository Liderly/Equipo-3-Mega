import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { loginDto } from '../interfaces/loginDto.interface';
import { LoginResponse } from '../interfaces/loginResponse.interface';
import { Observable, tap } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private readonly HttpClient:HttpClient) {
  }
  apiUrl:string=`${environment.apiUrl}/Auth`;
  login(user:loginDto){
    return this.HttpClient.post<LoginResponse>(`${this.apiUrl}/login`,user);
  }
  validateToken(token: string): Observable<any> {
    return this.HttpClient.post(`${this.apiUrl}/validate`, { token }).pipe(
      tap(
        (response) => {
          console.log('valido');
        },
        (error) => {
          this.clearLocalStorage();
        }
      )
    );
  }
  clearLocalStorage(): void {
   localStorage.clear();
  }
}
