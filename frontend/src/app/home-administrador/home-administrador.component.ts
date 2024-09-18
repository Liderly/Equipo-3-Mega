import { Component, OnInit } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home-administrador',
  standalone: true,
  imports: [RouterLink, RouterLinkActive, CommonModule],
  templateUrl: './home-administrador.component.html',
  styleUrls: ['./home-administrador.component.css']
})
export class HomeAdministradorComponent implements OnInit {
  data: any[] = []; // Aquí almacenaremos los datos

  ngOnInit(): void {
    // Datos simulados para prueba
    this.data = [
      { id: 1, trabajador: 'Juan Pérez', status: 'Completada', fecha: '2024-09-18', puntos: 50 },
      { id: 2, trabajador: 'María López', status: 'Pendiente', fecha: '2024-09-17', puntos: 30 },
      { id: 3, trabajador: 'Carlos García', status: 'Completada', fecha: '2024-09-16', puntos: 45 },
      { id: 4, trabajador: 'Ana Sánchez', status: 'Pendiente', fecha: '2024-09-15', puntos: 25 }
    ];
  }
}
