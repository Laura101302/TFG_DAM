import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductMayoristaComponent } from './product-mayorista.component';

describe('ProductMayoristaComponent', () => {
  let component: ProductMayoristaComponent;
  let fixture: ComponentFixture<ProductMayoristaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductMayoristaComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductMayoristaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
