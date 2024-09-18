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
      { id: 1, trabajador: 'Juan Pérez', ordenesCompletadas: 50, fecha: '2024-09-18', totalPuntos: 220, bono: this.calculateBonus(120) },
      { id: 2, trabajador: 'María López', ordenesCompletadas: 32, fecha: '2024-09-17', totalPuntos: 120, bono: this.calculateBonus(85) },
      { id: 3, trabajador: 'Carlos García', ordenesCompletadas: 40, fecha: '2024-09-16', totalPuntos: 140, bono: this.calculateBonus(155) },
      { id: 4, trabajador: 'Ana Sánchez', ordenesCompletadas: 20, fecha: '2024-09-15', totalPuntos: 40, bono: this.calculateBonus(211) }
    ];
  }

  // Método para calcular el bono según los puntos
  calculateBonus(points: number): number {
    if (points <= 80) {
      return 0;
    } else if (points <= 150) {
      return 300;
    } else if (points <= 210) {
      return 500;
    } else {
      return 650;
    }
  }
}
