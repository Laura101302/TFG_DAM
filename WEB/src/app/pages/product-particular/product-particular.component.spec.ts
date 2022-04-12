import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductParticularComponent } from './product-particular.component';

describe('ProductParticularComponent', () => {
  let component: ProductParticularComponent;
  let fixture: ComponentFixture<ProductParticularComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProductParticularComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductParticularComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
