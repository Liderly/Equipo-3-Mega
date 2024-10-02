import { TaskService } from './../../services/task.service';
import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { ButtonModule } from 'primeng/button';
import { IconFieldModule } from 'primeng/iconfield';
import { InputIconModule } from 'primeng/inputicon';
import { InputTextModule } from 'primeng/inputtext';
import { RippleModule } from 'primeng/ripple';
import { SidebarModule } from 'primeng/sidebar';
import { TableModule } from 'primeng/table';
import { TagModule } from 'primeng/tag';
import { Service, TechInfo } from '../../interfaces/tecResponse.interface';
import { UpdateTaskDto } from '../../interfaces/UpdateTaskDto.interface';

@Component({
  selector: 'app-tec-dashboard',
  standalone: true,
  imports: [RouterLink, RouterLinkActive,SidebarModule, CommonModule,TableModule,TagModule,ButtonModule, RippleModule,InputIconModule,IconFieldModule, InputTextModule,FormsModule],
  templateUrl: './tec-dashboard.component.html',
  styleUrl: './tec-dashboard.component.css'
})
export class TecDashboardComponent implements OnInit {
  constructor(private readonly TaskService:TaskService) {
    this.calculateCurrentWeekDates();
  }
  ngOnInit(): void {
    const numEmp: number = parseInt(localStorage.getItem('numEmp') ?? '0');
    this.TaskService.getTasksByEmp(numEmp).subscribe((data:TechInfo)=>{
      this.data=data;
    });
  }
  data:TechInfo={
    numTech:0,
    name:'Test',
    tasks:[]
  }
  currentWeekMonday!: Date;
  currentWeekSaturday!: Date;
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
  getStatusTag(
    status: string
  ): 'success' | 'secondary' | 'info' | 'warning' | 'danger' | undefined {
    switch (status) {
      case 'Completado':
        return 'success';
      case 'Pendiente':
        return 'warning';
      case 'En progreso':
        return 'info';
      case 'Cancelada':
        return 'danger';
      default:
        return undefined;
    }
  }
  updateTaskStatus(index:number,assigment_id:number,status:string){
    const body:UpdateTaskDto={
      technician_id:0,
      subscriber_id:0,
      service_id:0,
      status:status
    }
    this.TaskService.updateTask(assigment_id,body).subscribe((data)=>{
      if (data.message==='Tarea actualizada exitosamente') {
        this.data.tasks[index].status=status;
      }
    })

  }
}
