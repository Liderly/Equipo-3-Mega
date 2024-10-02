import { Routes } from '@angular/router';
import { UnauthenticatedGuard } from './guards/unauthenticated.guard';
import { AuthenticatedGuard } from './guards/authenticated.guard';

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
          ),canActivate: [UnauthenticatedGuard],
          title: 'Registros',
      },
      {
        path: 'Crear',
        loadComponent: () =>
          import('./pages/create-task-page/create-task-page.component').then(
            (m) => m.CreateTaskPageComponent
          ),title: 'Registrar Tarea',canActivate: [UnauthenticatedGuard],
      },
      { path: '**', redirectTo: 'Registros' },
    ],
  },
  {
    path: 'login',
    loadComponent: () =>
      import('./pages/login-page/login-page.component').then(
        (m) => m.LoginPageComponent
      ),title: 'Login',canActivate: [AuthenticatedGuard],
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
            ),title: 'Dashboard',canActivate: [UnauthenticatedGuard],
        },
        {
          path: '**',redirectTo: 'Dashboard',
        }
      ],
  },
  { path: '**', redirectTo: 'login' },
];
