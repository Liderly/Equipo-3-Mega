import { Component, CUSTOM_ELEMENTS_SCHEMA, OnInit } from '@angular/core';
import { DialogModule } from 'primeng/dialog';
import { FormBuilder, FormGroup, FormsModule, Validators } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { CalendarModule } from 'primeng/calendar';
import { InputTextModule } from 'primeng/inputtext';
import { TableModule } from 'primeng/table';
import { RippleModule } from 'primeng/ripple';
import { TagModule } from 'primeng/tag';
import { Service } from '../../interfaces/tecResponse.interface';
import { CommonModule } from '@angular/common';
import { RouterLink, RouterLinkActive } from '@angular/router';
import { IconFieldModule } from 'primeng/iconfield';
import { InputIconModule } from 'primeng/inputicon';
import { SidebarModule } from 'primeng/sidebar';
import { TaskService } from '../../services/task.service';
interface ResponseTask{
  totaltasks:number;
  tasks:Service[];
}
@Component({
  selector: 'app-create-task-page',
  standalone: true,
  imports: [
    DialogModule,
    FormsModule,
    ButtonModule,
    CalendarModule,
    InputTextModule,
    TableModule,
    TagModule,
    RippleModule,
    CommonModule,
    RouterLink,
    RouterLinkActive,
    SidebarModule,
    InputIconModule,
    IconFieldModule
  ],
  templateUrl: './create-task-page.component.html',
  styleUrls: ['./create-task-page.component.css'],
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA
  ]
})
export class CreateTaskPageComponent implements OnInit {
  public data: ResponseTask;
  public displayModal = false;
  public taskForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private taskService: TaskService
  ) {
    this.data = {
      totaltasks: 0,
      tasks: [],
    };
    this.taskForm = this.fb.group({
      workerName: ['', Validators.required],
      clientName: ['', Validators.required],
      clientAddress: ['', Validators.required],
      taskDate: [null, Validators.required],
      servicePerformed: ['', Validators.required],
    });
  }
  currentWeekMonday!: Date;
  currentWeekSaturday!: Date;
  ngOnInit() {
    this.calculateCurrentWeekDates();
    this.loadTasks();
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
  loadTasks() {
    this.taskService.getTasks().subscribe(
      (response:any) => {
        this.data = response;
      },
      (error:any) => {
        console.error('Error loading tasks', error);
      }
    );
  }

  showModal() {
    this.displayModal = true;
  }

  hideModal() {
    this.displayModal = false;
    this.taskForm.reset();
  }

  onSubmit() {
    if (this.taskForm.valid) {
      this.taskService.createTask(this.taskForm.value).subscribe(
        (response:any) => {
          console.log('Task created', response);
          this.hideModal();
          this.loadTasks(); // Reload tasks after creating a new one
        },
        (error:any) => {
          console.error('Error creating task', error);
        }
      );
    }
  }

  // ... (resto de los métodos)
}
