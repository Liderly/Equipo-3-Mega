import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { TechInfo } from '../interfaces/tecResponse.interface';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private readonly HttpClient:HttpClient) {

   }
   apiurl:string=`${environment.apiUrl}/Tasks`;
    getTasksByEmp(NumEmp:number):Observable <TechInfo>{
      return this.HttpClient.get<TechInfo>(`${this.apiurl}/${NumEmp}`);
    }
}
