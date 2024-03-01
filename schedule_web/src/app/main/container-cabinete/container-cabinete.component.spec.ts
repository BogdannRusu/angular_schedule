import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContainerCabineteComponent } from './container-cabinete.component';

describe('ContainerCabineteComponent', () => {
  let component: ContainerCabineteComponent;
  let fixture: ComponentFixture<ContainerCabineteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ContainerCabineteComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ContainerCabineteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
