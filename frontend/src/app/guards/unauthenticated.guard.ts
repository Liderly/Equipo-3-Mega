import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { AuthService } from '../services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class UnauthenticatedGuard implements CanActivate {
  constructor(private router: Router, private authService: AuthService) {}

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> {
    const token = localStorage.getItem('token');
    if (!token) {
      this.router.navigate(['/login']);
      return of(false);
    }
    return this.authService.validateToken(token).pipe(
      map(response => {
        if (response.message === "token es valido") {
          return true;
        }
        this.authService.clearLocalStorage();
        this.router.navigate(['/login']);
        return false;
      }),
      catchError(() => {
        this.authService.clearLocalStorage();
        this.router.navigate(['/login']);
        return of(false);
      })
    );
  }
}
