import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { AuthService } from '../services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class AuthenticatedGuard implements CanActivate {
  constructor(private router: Router, private authService: AuthService) {}

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> {
    const token = localStorage.getItem('token');

    if (!token) {
      return of(true); 
    }

    return this.authService.validateToken(token).pipe(
      map(response => {
        if (response.message === "token es valido") {
          const role = localStorage.getItem('role');
          if (role === 'Admin') {
            this.router.navigate(['/Admin']);
          } else if (role === 'Tecnico') {
            this.router.navigate(['/Tecnicos']);
          }
          return false;
        }
        return true;
      }),
      catchError(() => {
        this.authService.clearLocalStorage();
        return of(true);
      })
    );
  }
}
