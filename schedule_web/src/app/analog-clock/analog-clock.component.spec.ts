import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AnalogCloclComponent } from './analog-clock.component';

describe('AnalogCloclComponent', () => {
  let component: AnalogCloclComponent;
  let fixture: ComponentFixture<AnalogCloclComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AnalogCloclComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AnalogCloclComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
