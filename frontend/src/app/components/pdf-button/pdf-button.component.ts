import { Component, input } from '@angular/core';
import { Technitian } from '../../interfaces/techniciansListResponse.interface';
import jsPDF from 'jspdf';
import { BonusService } from '../../services/bonus.service';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'pdf-button',
  standalone: true,
  imports: [ButtonModule],
  providers: [BonusService],
  templateUrl: './pdf-button.component.html',
  styleUrl: './pdf-button.component.css'
})
export class PdfButtonComponent {
  constructor(private bonusService: BonusService) {}
  currentWeekMonday=input.required<Date>();
  currentWeekSaturday=input.required<Date>();
  total_Technicians=input.required<number>();
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
    pdf.text(`Total de técnicos: ${this.total_Technicians()}`, 105, 18.5, {
      align: 'center',
    });
    pdf.setFont('italic','bold');
    pdf.setFontSize(10);
    pdf.text(
      `Ciclo del: ${this.currentWeekMonday().toLocaleDateString('es-ES', {
        day: '2-digit',
        month: '2-digit',
        year: 'numeric',
      })} - ${this.currentWeekSaturday().toLocaleDateString('es-ES', {
        day: '2-digit',
        month: '2-digit',
        year: 'numeric',
      })}`,
      105,
      25,
      { align: 'center' }
    );
    //IMAGEN DE LOGO EN PARTE SUPERIOR DERECHA
    var imgWidth = 40; // Ancho de la imagen
    var imgHeight = 20; // Alto de la imagen
    var pageWidth = pdf.internal.pageSize.getWidth();
    var xPosition = pageWidth - imgWidth-10; // Margen derecho de 10 unidades
    var yPosition = 5; // Posición en Y (por ejemplo, margen superior de 10 unidades)
    pdf.addImage('https://companieslogo.com/img/orig/MEGACPO.MX_BIG-a640e1b7.png?t=1720244492', 'PNG', xPosition, yPosition, imgWidth, imgHeight);
    //MARCA DE AGUA
    var markimgWidth = pageWidth * 0.7;
    var markimgHeight = markimgWidth * 0.5;
    var markxPosition = 30;
    var markyPosition = (pageHeight - imgHeight) / 2;
// Agrega la imagen centrada en la página

await this.addImageWithOpacity(
  pdf,
  'https://companieslogo.com/img/orig/MEGACPO.MX-2b00e1a8.png?t=1720244492',
  markxPosition,
  markyPosition,
  markimgWidth,
  markimgHeight,
  0.3  // Opacidad (0.0 a 1.0)
);
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

    position += 15;
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
    return await this.bonusService.GetAllReports();
  }
  async addImageWithOpacity(
    pdf: jsPDF,
    imgSrc: string,
    x: number,
    y: number,
    width: number,
    height: number,
    opacity: number
  ): Promise<void> {
    return new Promise((resolve, reject) => {
      const img = new Image();
      img.src = imgSrc;
      img.crossOrigin = "Anonymous";  // Necesario para imágenes de otros dominios
      img.onload = function() {
        const canvas = document.createElement('canvas');
        const ctx = canvas.getContext('2d')!;
        canvas.width = width;
        canvas.height = height;
        // Dibujar un fondo blanco (opcional, depende de tu necesidad)
        ctx.fillStyle = 'white';
        ctx.fillRect(0, 0, canvas.width, canvas.height);
        // Dibujar la imagen con opacidad
        ctx.globalAlpha = opacity;
        ctx.drawImage(img, 0, 0, width, height);
        // Convertir el canvas a una imagen data URL
        const dataUrl = canvas.toDataURL('image/png');
        // Agregar la imagen procesada al PDF
        pdf.addImage(dataUrl, 'PNG', x, y, width, height);
        resolve();
      };
      img.onerror = reject;
    });
  }

}
