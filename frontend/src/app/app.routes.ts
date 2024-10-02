import { Routes } from '@angular/router';
import { UnauthenticatedGuard } from './guards/unauthenticated.guard';
import { AuthenticatedGuard } from './guards/authenticated.guard';
import { IsTechnitianGuard } from './guards/is-technitian.guard';
import { IsAdminGuard } from './guards/is-admin.guard';

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
          ),canActivate: [UnauthenticatedGuard,IsAdminGuard],
          title: 'Registros',
      },
      {
        path: 'Crear',
        loadComponent: () =>
          import('./pages/create-task-page/create-task-page.component').then(
            (m) => m.CreateTaskPageComponent
          ),title: 'Registrar Tarea',canActivate: [UnauthenticatedGuard,IsAdminGuard],
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
            ),title: 'Dashboard',canActivate: [UnauthenticatedGuard,IsTechnitianGuard],
        },
        {
          path: '**',redirectTo: 'Dashboard',
        }
      ],
  },
  { path: '**', redirectTo: 'login' },
];
