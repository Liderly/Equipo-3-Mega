import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TecDashboardComponent } from './tec-dashboard.component';

describe('TecDashboardComponent', () => {
  let component: TecDashboardComponent;
  let fixture: ComponentFixture<TecDashboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TecDashboardComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TecDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
