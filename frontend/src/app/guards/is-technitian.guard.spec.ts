import { TestBed } from '@angular/core/testing';
import { CanActivateFn } from '@angular/router';

import { isTechnitianGuard } from './is-technitian.guard';

describe('isTechnitianGuard', () => {
  const executeGuard: CanActivateFn = (...guardParameters) => 
      TestBed.runInInjectionContext(() => isTechnitianGuard(...guardParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeGuard).toBeTruthy();
  });
});
