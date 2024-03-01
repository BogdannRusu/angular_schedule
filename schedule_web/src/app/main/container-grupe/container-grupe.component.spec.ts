import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ContainerGrupeComponent } from './container-grupe.component';

describe('ContainerGrupeComponent', () => {
  let component: ContainerGrupeComponent;
  let fixture: ComponentFixture<ContainerGrupeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ContainerGrupeComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ContainerGrupeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
