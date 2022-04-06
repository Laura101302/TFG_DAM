import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MensajeFinalComponent } from './mensaje-final.component';

describe('MensajeFinalComponent', () => {
  let component: MensajeFinalComponent;
  let fixture: ComponentFixture<MensajeFinalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MensajeFinalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MensajeFinalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
