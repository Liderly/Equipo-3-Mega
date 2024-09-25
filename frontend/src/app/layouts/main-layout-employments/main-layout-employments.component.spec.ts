import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainLayoutEmploymentsComponent } from './main-layout-employments.component';

describe('MainLayoutEmploymentsComponent', () => {
  let component: MainLayoutEmploymentsComponent;
  let fixture: ComponentFixture<MainLayoutEmploymentsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [MainLayoutEmploymentsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MainLayoutEmploymentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
