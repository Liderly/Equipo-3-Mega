import { Component, OnInit, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { SidebarModule } from 'primeng/sidebar';
import { BonusService } from '../../services/bonus.service';
import { Table, TableModule } from 'primeng/table';
import { TagModule } from 'primeng/tag';
import { ButtonModule } from 'primeng/button';
import { RippleModule } from 'primeng/ripple';
import { BonusListResponse, Technitian } from '../../interfaces/techniciansListResponse.interface';
import { InputIconModule } from 'primeng/inputicon';
import { IconFieldModule } from 'primeng/iconfield';
import { InputTextModule } from 'primeng/inputtext';
import { FormsModule } from '@angular/forms';
import jsPDF from 'jspdf';

@Component({
  selector: 'app-registros',
  standalone: true,
  imports: [RouterLink, RouterLinkActive,SidebarModule, CommonModule,TableModule,TagModule,ButtonModule, RippleModule,InputIconModule,IconFieldModule, InputTextModule,FormsModule],
  providers: [BonusService],
  templateUrl: './registros.component.html',
  styleUrls: ['./registros.component.css'],
})
export class RegistrosComponent implements OnInit {
  constructor(private bonusService: BonusService) {
    this.calculateCurrentWeekDates();
   }
  @ViewChild('TechsTable') TechsTable!: Table;
  currentWeekMonday!: Date;
  currentWeekSaturday!: Date;
  searchTerm: string = '';
  data: BonusListResponse={
    technitians:[],
    total_Technicians:0
  }; // Aquí almacenaremos los datos
  datafields:string[] = ["Id","Trabajador","Numero de cliente","Tareas","Estatus","Fecha de tarea","Puntos obtenidos"];
  showSideNav: boolean = false;
 ngOnInit(): void {
    // Datos simulados para prueba
    this.fetchData();
  }
   onPageChange(event: any) {
    const pageNumber = (event.first /10)+1; // Página actual
    this.ChangePage(pageNumber);
  }

  getStatusTag(
    status: string
  ): 'success' | 'secondary' | 'info' | 'warning' | 'danger' | undefined {
    switch (status) {
      case 'Completado':
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
  calculateCurrentWeekDates() {
    const today = new Date();
    const currentDay = today.getDay();
    // Calcular el lunes de semana en curso
    this.currentWeekMonday = new Date(today);
    this.currentWeekMonday.setDate(today.getDate() - currentDay + (currentDay === 0 ? -6 : 1))
    // Calcular el sabado de semana en curso
    this.currentWeekSaturday = new Date(this.currentWeekMonday);
    this.currentWeekSaturday.setDate(this.currentWeekMonday.getDate() + 5);
  }
  resetTable(){
    this.searchTerm=''
    this.fetchData();
  }
  getTotalCompleteTask(data: Technitian): number {
    return data.tasks.reduce((acc: number, task: any) => {
        // Validación: solo contar si el estado es 'Completada'
        if (task.status === 'Completada') {
            acc += 1;
        }
        return acc; // Retornar el acumulador
    }, 0); // Valor inicial del acumulador
}
fetchData(){
  this.bonusService.GetBonusReport(1).subscribe((data: BonusListResponse) => {
    this.data = data;
  });
}
ChangePage(page:number){
  this.bonusService.GetBonusReport(page).subscribe((data: BonusListResponse) => {
    this.data = data;
  });
}
searchTech($event: any){
  if ($event.key === "Enter"){
    this.bonusService.GetBonusReport(1,parseInt(this.searchTerm)).subscribe((data: BonusListResponse) => {
      this.data = data;
    });
  }
}

  async generatePDF() {
    const pdf = new jsPDF('p', 'mm', 'a4');
    const pageHeight = 295;
    let position = 20;

    pdf.setFontSize(16);
    pdf.setTextColor(40);
    pdf.setFont('helvetica', 'bold');

    pdf.text('Reporte de Técnicos', 105, 10, { align: 'center' });
    pdf.setFontSize(12);
    pdf.setTextColor(100);
    pdf.text(`Total de técnicos: ${this.data.total_Technicians}`, 105, 15, {
      align: 'center',
    });

    const headers = [
      '#',
      'NumTech',
      'Nombre',
      'Tareas Completadas',
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
    const Techs:Technitian[]=await this.getAllReports();
    Techs.forEach((technitian, index) => {
      const row = [
        (index + 1).toString(),
        technitian.numTech.toString(),
        technitian.name,
        technitian.tasks.filter(task => task.status === 'Completado').length.toString(),
        technitian.crew.toString(),
        technitian.totalPoints.toString(),
        technitian.totalBonus.toString(),
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
      const textXPos = xPos + 5; // Un pequeño margen izquierdo
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

  getColumnOffset(columnWidths:number[], index: number): number {
    return columnWidths.slice(0, index).reduce((a, b) => a + b, 0);
  }
   async getAllReports(): Promise<Technitian[]> {
    console.log(await this.bonusService.GetAllReports());
    return await this.bonusService.GetAllReports();
  }
}
