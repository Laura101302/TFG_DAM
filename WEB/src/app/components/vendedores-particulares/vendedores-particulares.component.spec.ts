import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VendedoresParticularesComponent } from './vendedores-particulares.component';

describe('VendedoresParticularesComponent', () => {
  let component: VendedoresParticularesComponent;
  let fixture: ComponentFixture<VendedoresParticularesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VendedoresParticularesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VendedoresParticularesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
