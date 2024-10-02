import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { TechInfo } from '../interfaces/tecResponse.interface';
import { UpdateTaskDto } from '../interfaces/UpdateTaskDto.interface';
import { UpdateTaskResponse } from '../interfaces/UpdateTaskResponse.interface';

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
    createTask(task:any):Observable<TechInfo>{
      return this.HttpClient.post<TechInfo>(this.apiurl,task);
    }
    getTasks():Observable<TechInfo>{
      return this.HttpClient.get<TechInfo>(this.apiurl);
    }
    updateTask(taskid:number,task:UpdateTaskDto):Observable<UpdateTaskResponse>{
      return this.HttpClient.put<UpdateTaskResponse>(`${this.apiurl}/${taskid}`,task);
    }
}
