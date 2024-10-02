import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';

export const IsTechnitianGuard: CanActivateFn = (route, state) => {
  const router=inject(Router);
  const role=localStorage.getItem('role');
  if (role==='Tecnico') {
    return true;
  }
  else {
    router.navigate(['/login']);
    return false;
  }
};
