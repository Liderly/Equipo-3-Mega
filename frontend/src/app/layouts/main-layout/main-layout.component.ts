import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Router, RouterLink, RouterLinkActive, RouterModule, RouterOutlet } from '@angular/router';
import { SidebarModule } from 'primeng/sidebar';
interface userOptions{
description:string;
icon:string;
route:string;
}
@Component({
  selector: 'app-main-layout',
  standalone: true,
  imports: [RouterLink,RouterOutlet, RouterLinkActive,SidebarModule, CommonModule,RouterModule],
  templateUrl: './main-layout.component.html',
  styleUrl: './main-layout.component.css'
})
export class MainLayoutComponent {
  constructor(private readonly router:Router) { }
  options: userOptions[] = [
    { description: "Registros", route: "/Admin/Registros", icon: "fas fa-file-alt" },
    { description: "Registrar tarea", route: "/Admin/Crear", icon: "fas fa-plus" }
  ];
  showSideNav: boolean = false;

Logout(){
  this.showSideNav = false;
  this.router.navigate(["/login"]);
}
}
