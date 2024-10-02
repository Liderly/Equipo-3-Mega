import { AuthService } from './../../services/auth.service';
import { CommonModule } from '@angular/common';
import { ValidatorService } from './../../validators/validator.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-login-page',
  standalone: true,
  imports: [RouterModule,ReactiveFormsModule,FormsModule,CommonModule],
  templateUrl: './login-page.component.html',
  styleUrl: './login-page.component.css'
})
export class LoginPageComponent implements OnInit {
  loginForm!: FormGroup;
  MessageError: string="";
constructor(
  private readonly router:Router,
  private readonly FB:FormBuilder,
  private readonly ValidatorService:ValidatorService,
  private readonly AuthService:AuthService) {
  this.loginForm = this.FB.group({
    email: ['', Validators.required],
    password: ['', Validators.required]
  });
}
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

login(){
this.loginForm.markAllAsTouched();
this.MessageError="";
if(this.loginForm.valid){
  this.MessageError="";
  this.AuthService.login(this.loginForm.value).subscribe(
    (data) => {
      console.log(data);
      if (data.message === "Login exitoso") {
        localStorage.setItem('token', data.token);
        localStorage.setItem('numEmp', data.numEmp.toString());
        localStorage.setItem('role', data.role);

        if (data.role === "Admin") {
          this.router.navigate(['/Admin']);
        } else if (data.role === "Tecnico") {
          this.router.navigate(['/Tecnicos']);
        }
      } else {
        this.MessageError = data.message;
      }
    },
    (error) => {
      console.error('Error en el login:', error);
      if (error.error && error.error.message) {
        this.MessageError = error.error.message;
      } else if (error.message) {
        this.MessageError = error.message;
      } else {
        this.MessageError = 'Ocurrió un error durante el login. Por favor, intente de nuevo.';
      }
    }
  );
}
}
IsInvalidField(field: string): boolean | null {
  return this.ValidatorService.isValidField(this.loginForm, field);
}
getErrorMessage(field: string): string | null {
  return this.ValidatorService.getFieldErrorMessage(this.loginForm, field);
}
}
