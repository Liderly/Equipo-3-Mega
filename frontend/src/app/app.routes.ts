import { Routes } from '@angular/router';
import { HomeAdministradorComponent } from './home-administrador/home-administrador.component';
import { RegistrosComponent } from './registros/registros.component';

export const routes: Routes = [
  { path: '', component: HomeAdministradorComponent },
  { path: 'registros', component: RegistrosComponent },
  { path: '**', redirectTo: '' }
];