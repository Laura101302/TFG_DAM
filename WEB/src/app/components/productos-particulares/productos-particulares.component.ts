import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-productos-particulares',
  templateUrl: './productos-particulares.component.html',
  styleUrls: ['./productos-particulares.component.css']
})
export class ProductosParticularesComponent implements OnInit {

  images = ['camiseta', 'pantalon', 'piano', 'portatil', 'sudadera'].map((n) => `/assets/images/particulares/${n}.jpg`);

  constructor() { }

  ngOnInit(): void {
  }

}
