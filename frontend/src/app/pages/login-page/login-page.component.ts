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
constructor(private readonly router:Router,private readonly FB:FormBuilder,private readonly ValidatorService:ValidatorService) {
  this.loginForm = this.FB.group({
    NumEmpleado: ['', Validators.required],
    password: ['', Validators.required]
  });
}
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }

login(){
this.loginForm.markAllAsTouched();
if(this.loginForm.valid){
  this.router.navigate(['/registros']);
}
}
IsInvalidField(field: string): boolean | null {
  return this.ValidatorService.isValidField(this.loginForm, field);
}
getErrorMessage(field: string): string | null {
  return this.ValidatorService.getFieldErrorMessage(this.loginForm, field);
}
}
