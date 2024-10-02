import { Component } from '@angular/core';
import { DialogModule } from 'primeng/dialog';
import { FormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { CalendarModule } from 'primeng/calendar';
import { InputTextModule } from 'primeng/inputtext';

@Component({
  selector: 'app-create-task-page',
  standalone: true,
  imports: [
    DialogModule,
    FormsModule,
    ButtonModule,
    CalendarModule,
    InputTextModule,
  ],
  templateUrl: './create-task-page.component.html',
  styleUrls: ['./create-task-page.component.css'],
})
export class CreateTaskPageComponent {
  displayModal: boolean = false;

  // Funciones para mostrar y ocultar el modal
  showModal() {
    this.displayModal = true;
  }

  hideModal() {
    this.displayModal = false;
  }
}
