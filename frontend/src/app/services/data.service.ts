import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  private apiUrl = 'URL_DE_TU_API'; // Reemplaza con la URL de tu API

  constructor(private http: HttpClient) { }

  // Método para obtener los datos del backend
  getData(): Observable<any> {
    return this.http.get<any>(this.apiUrl);
  }
}
