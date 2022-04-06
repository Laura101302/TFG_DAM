import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductosMayoristasComponent } from './productos-mayoristas.component';

describe('ProductosMayoristasComponent', () => {
  let component: ProductosMayoristasComponent;
  let fixture: ComponentFixture<ProductosMayoristasComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductosMayoristasComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductosMayoristasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
