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
          ),canActivate: [],
          title: 'Registros',
      },
      {
        path: 'Crear',
        loadComponent: () =>
          import('./pages/create-task-page/create-task-page.component').then(
            (m) => m.CreateTaskPageComponent
          ),title: 'Registrar Tarea',
      },
      { path: '**', redirectTo: 'Registros' },
    ],
  },
  {
    path: 'login',
    loadComponent: () =>
      import('./pages/login-page/login-page.component').then(
        (m) => m.LoginPageComponent
      ),title: 'Login',
  },
  {
    path: 'Tecnicos',
    loadComponent: () =>
      import(
        './layouts/main-layout-employments/main-layout-employments.component'
      ).then((m) => m.MainLayoutEmploymentsComponent),children: [
        {
          path: 'Dashboard',
          loadComponent: () =>
            import('./pages/tec-dashboard/tec-dashboard.component').then(
              (m) => m.TecDashboardComponent
            ),title: 'Dashboard',canActivate: [],
        },
        {
          path: '**',redirectTo: 'Dashboard',
        }
      ],
  },
  { path: '**', redirectTo: 'login' },
];
