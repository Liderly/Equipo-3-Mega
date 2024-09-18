import { Component, OnInit } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-registros',
  standalone: true,
  imports: [RouterLink, RouterLinkActive, CommonModule],
  templateUrl: './registros.component.html',
  styleUrls: ['./registros.component.css']
})
export class RegistrosComponent implements OnInit {
  data: any[] = []; // Aquí almacenaremos los datos de prueba

  ngOnInit(): void {
    // Datos simulados para prueba
    this.data = [
      { id: 1, trabajador: 'Juan Pérez', ordenesCompletadas: 5, fecha: '2024-09-18', totalPuntos: 120, bono: 50 },
      { id: 2, trabajador: 'María López', ordenesCompletadas: 3, fecha: '2024-09-17', totalPuntos: 90, bono: 30 },
      { id: 3, trabajador: 'Carlos García', ordenesCompletadas: 4, fecha: '2024-09-16', totalPuntos: 100, bono: 45 },
      { id: 4, trabajador: 'Ana Sánchez', ordenesCompletadas: 2, fecha: '2024-09-15', totalPuntos: 60, bono: 25 }
    ];
  }
}
