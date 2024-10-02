import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { SidebarModule } from 'primeng/sidebar';
interface userOptions{
  description:string;
  icon:string;
  route:string;
  }
@Component({
  selector: 'app-main-layout-employments',
  standalone: true,
  imports: [RouterModule,CommonModule,SidebarModule],
  templateUrl: './main-layout-employments.component.html',
  styleUrl: './main-layout-employments.component.css'
})
export class MainLayoutEmploymentsComponent {
  constructor(private readonly router:Router) { }
  options: userOptions[] = [
    { description: "Registros", route: "/Tecnicos/Tareas", icon: "pi pi-check-square" },
  ];
  showSideNav: boolean = false;

  Logout(){
    localStorage.clear();
    this.showSideNav = false;
    this.router.navigate(["/login"]);
  }
}
