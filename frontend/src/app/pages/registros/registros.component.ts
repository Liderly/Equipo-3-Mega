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
import { PdfButtonComponent } from '../../components/pdf-button/pdf-button.component';

@Component({
  selector: 'app-registros',
  standalone: true,
  imports: [RouterLink, RouterLinkActive,SidebarModule, CommonModule,TableModule,TagModule,ButtonModule, RippleModule,InputIconModule,IconFieldModule, InputTextModule,FormsModule,PdfButtonComponent],
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
        if (task.status === 'Completado') {
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


}
