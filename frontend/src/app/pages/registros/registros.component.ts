import { Component, OnInit, ViewChild } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { CommonModule } from '@angular/common';
import { SidebarModule } from 'primeng/sidebar';
import { TasksService } from '../../services/tasks.service';
import { Table, TableModule } from 'primeng/table';
import { TagModule } from 'primeng/tag';
import { ButtonModule } from 'primeng/button';
import { RippleModule } from 'primeng/ripple';
import { data } from './data_test';
import { TechListResponse, Technitian } from '../../interfaces/techniciansListResponse.interface';
import { InputIconModule } from 'primeng/inputicon';
import { IconFieldModule } from 'primeng/iconfield';
import { InputTextModule } from 'primeng/inputtext';
import { FormsModule, NgModel } from '@angular/forms';

@Component({
  selector: 'app-registros',
  standalone: true,
  imports: [RouterLink, RouterLinkActive,SidebarModule, CommonModule,TableModule,TagModule,ButtonModule, RippleModule,InputIconModule,IconFieldModule, InputTextModule,FormsModule],
  providers: [TasksService],
  templateUrl: './registros.component.html',
  styleUrls: ['./registros.component.css']
})
export class RegistrosComponent implements OnInit {
  @ViewChild('TechsTable') TechsTable!: Table;
  searchTerm: string = ''; 
  data: TechListResponse={
    technitians:[],
    totalTechs:0
  }; // Aquí almacenaremos los datos
  datafields:string[] = ["Id","Trabajador","Numero de cliente","Tareas","Estatus","Fecha de tarea","Puntos obtenidos"];
  showSideNav: boolean = false;
  ngOnInit(): void {
    // Datos simulados para prueba
    this.data = data;
  }
  getStatusTag(status: string) :"success" | "secondary" | "info" | "warning" | "danger"  | undefined {
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
  getTotalPoints(data: Technitian):number {
    return data.tasks.reduce((acc: number, task: any) => acc + task.puntos, 0);
  }
  getTotalBono(data:any) {
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
}
