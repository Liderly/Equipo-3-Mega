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
import html2canvas from 'html2canvas';

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
  data = data; // Aquí tienes tus datos
  totalTechs: number = 0;

  ngOnInit(): void {
    // Asigna los datos y calcula el total de técnicos
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
    // Mostrar todas las filas antes de generar el PDF
    const originalRows = this.TechsTable.rows;
    this.TechsTable.rows = this.totalTechs;
    this.TechsTable.reset();

    setTimeout(() => {
      const dataElement = document.getElementById('tablesToExport');
      if (dataElement) {
        html2canvas(dataElement, {
          onclone: (clonedDoc) => {
            // Ocultar elementos no deseados en el documento clonado
            clonedDoc.querySelectorAll('.elementsToHide').forEach((element) => {
              (element as HTMLElement).style.display = 'none';
            });
          },
        }).then((canvas) => {
          const imgWidth = 210;
          const pageHeight = 295;
          const imgHeight = (canvas.height * imgWidth) / canvas.width;
          let heightLeft = imgHeight;

          const pdf = new jsPDF('p', 'mm', 'a4');
          let position = 0;

          pdf.addImage(canvas, 'PNG', 0, position, imgWidth, imgHeight);
          heightLeft -= pageHeight;

          while (heightLeft > 0) {
            position = heightLeft - imgHeight;
            pdf.addPage();
            pdf.addImage(canvas, 'PNG', 0, position, imgWidth, imgHeight);
            heightLeft -= pageHeight;
          }

          pdf.save('tabla-tecnicos.pdf');

          // Restaurar el número original de filas
          this.TechsTable.rows = originalRows;
          this.TechsTable.reset();
        });
      }
    }, 1000); // Ajusta el tiempo según sea necesario
  }
}
