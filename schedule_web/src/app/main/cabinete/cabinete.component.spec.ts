import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CabineteComponent } from './cabinete.component';

describe('CabineteComponent', () => {
  let component: CabineteComponent;
  let fixture: ComponentFixture<CabineteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CabineteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CabineteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
