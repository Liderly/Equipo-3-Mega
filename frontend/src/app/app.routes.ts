import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: 'Admin',
    loadComponent: () =>
      import('./layouts/main-layout/main-layout.component').then(
        (m) => m.MainLayoutComponent
      ),
    children: [
      {
        path: 'Registros',
        loadComponent: () =>
          import('./pages/registros/registros.component').then(
            (m) => m.RegistrosComponent
          ),
      },
      {
        path: 'Crear',
        loadComponent: () =>
          import('./pages/create-task-page/create-task-page.component').then(
            (m) => m.CreateTaskPageComponent
          ),
      },
      { path: '**', redirectTo: 'Registros' },
    ],
  },
  {
    path: 'login',
    loadComponent: () =>
      import('./pages/login-page/login-page.component').then(
        (m) => m.LoginPageComponent
      ),
  },
  {
    path: 'employements',
    loadComponent: () =>
      import(
        './layouts/main-layout-employments/main-layout-employments.component'
      ).then((m) => m.MainLayoutEmploymentsComponent),
  },
  { path: '**', redirectTo: 'login' },
];
