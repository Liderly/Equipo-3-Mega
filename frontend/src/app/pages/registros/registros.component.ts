import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { SidebarModule } from 'primeng/sidebar';
import { Table, TableModule } from 'primeng/table';
import { TagModule } from 'primeng/tag';
import { ButtonModule } from 'primeng/button';
import { RippleModule } from 'primeng/ripple';
import { InputIconModule } from 'primeng/inputicon';
import { IconFieldModule } from 'primeng/iconfield';
import { InputTextModule } from 'primeng/inputtext';
import { FormsModule } from '@angular/forms';
import { Technitian } from '../../interfaces/techniciansListResponse.interface';
import { data } from './data_test';
import jsPDF from 'jspdf';

@Component({
  selector: 'app-registros',
  standalone: true,
  imports: [
    CommonModule,
    RouterLink,
    RouterLinkActive,
    SidebarModule,
    TableModule,
    TagModule,
    ButtonModule,
    RippleModule,
    InputIconModule,
    IconFieldModule,
    InputTextModule,
    FormsModule,
  ],
  templateUrl: './registros.component.html',
  styleUrls: ['./registros.component.css'],
})
export class RegistrosComponent implements OnInit {
  @ViewChild('TechsTable') TechsTable!: Table;
  searchTerm: string = '';
  data = data;
  totalTechs: number = 0;

  ngOnInit(): void {
    this.data = data;
    this.totalTechs = this.data.technitians.length;
  }

  getStatusTag(
    status: string
  ): 'success' | 'secondary' | 'info' | 'warning' | 'danger' | undefined {
    switch (status) {
      case 'Completada':
        return 'success';
      case 'Pendiente':
        return 'warning';
      case 'En proceso':
        return 'info';
      case 'Cancelada':
        return 'danger';
      default:
        return undefined;
    }
  }

  getTotalPoints(data: Technitian): number {
    return data.tasks.reduce((acc: number, task: any) => acc + task.puntos, 0);
  }

  getTotalBono(data: Technitian): number {
    const points = this.getTotalPoints(data);
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

  filterGlobal(event: any) {
    if (this.TechsTable) {
      this.TechsTable.filterGlobal(event.target.value, 'contains');
    }
  }

  generatePDF() {
    const pdf = new jsPDF('p', 'mm', 'a4');
    const pageHeight = 295;
    let position = 20;

    pdf.setFontSize(16);
    pdf.setTextColor(40);
    pdf.setFont('helvetica', 'bold');

    pdf.text('Reporte de Técnicos', 105, 10, { align: 'center' });
    pdf.setFontSize(12);
    pdf.setTextColor(100);
    pdf.text(`Total de técnicos: ${this.totalTechs}`, 105, 15, {
      align: 'center',
    });

    const headers = [
      '#',
      'NumTech',
      'Nombre',
      'Dirección',
      'Cuadrilla',
      'Puntos',
      'Bono',
    ];
    const columnWidths = [10, 30, 40, 50, 25, 20, 20];

    position += 10;
    this.generateTableHeader(pdf, headers, columnWidths, position);
    position += 10;

    pdf.setFontSize(10);
    pdf.setTextColor(50);

    this.data.technitians.slice(0, 10).forEach((technitian, index) => {
      const row = [
        (index + 1).toString(),
        technitian.NumTech,
        technitian.name,
        technitian.address,
        technitian.crew,
        this.getTotalPoints(technitian).toString(),
        `$${this.getTotalBono(technitian).toString()}`,
      ];

      this.generateTableRow(pdf, row, columnWidths, position);
      position += 10;

      if (position >= pageHeight - 20) {
        pdf.addPage();
        position = 20;
        this.generateTableHeader(pdf, headers, columnWidths, position);
        position += 10;
      }
    });

    pdf.save('reporte-tecnicos.pdf');
  }
  generateTableHeader(
    pdf: jsPDF,
    headers: string[],
    columnWidths: number[],
    yPos: number
  ) {
    pdf.setFontSize(10);
    pdf.setFont('helvetica', 'bold');
    pdf.setTextColor(0, 0, 0); // Aseguramos que el texto sea negro
    pdf.setDrawColor(0); // Color de las líneas de los rectángulos
    pdf.setLineWidth(0.2); // Grosor de las líneas

    headers.forEach((header, index) => {
      const xPos = 10 + this.getColumnOffset(columnWidths, index);
      const cellHeight = 10;
      const cellYPos = yPos - 5;

      // Dibujar el rectángulo de la cabecera sin relleno
      pdf.rect(xPos, cellYPos, columnWidths[index], cellHeight);

      // Dibujar el texto de la cabecera
      const textXPos = xPos + 2; // Un pequeño margen izquierdo
      const textYPos = cellYPos + 6; // Ajustamos para centrar verticalmente
      pdf.text(header, textXPos, textYPos);
    });

    pdf.setFont('helvetica', 'normal');
  }

  generateTableRow(
    pdf: jsPDF,
    row: string[],
    columnWidths: number[],
    yPos: number
  ) {
    row.forEach((cell, index) => {
      const xPos = 10 + this.getColumnOffset(columnWidths, index);
      pdf.rect(xPos, yPos - 5, columnWidths[index], 10);
      pdf.text(cell, xPos + columnWidths[index] / 2, yPos, {
        align: 'center',
        baseline: 'middle',
      });
    });
  }

  getColumnOffset(columnWidths: number[], index: number): number {
    return columnWidths.slice(0, index).reduce((a, b) => a + b, 0);
  }
}
