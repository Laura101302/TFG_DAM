import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductosParticularesComponent } from './productos-particulares.component';

describe('ProductosParticularesComponent', () => {
  let component: ProductosParticularesComponent;
  let fixture: ComponentFixture<ProductosParticularesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductosParticularesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductosParticularesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
