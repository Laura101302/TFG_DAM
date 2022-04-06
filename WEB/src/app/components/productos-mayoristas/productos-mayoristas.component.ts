import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-productos-mayoristas',
  templateUrl: './productos-mayoristas.component.html',
  styleUrls: ['./productos-mayoristas.component.css']
})
export class ProductosMayoristasComponent implements OnInit {

  images = ['altavoz', 'lampara', 'mesa', 'monitor', 'silla'].map((n) => `/assets/images/mayoristas/${n}.jpg`);

  constructor() { }

  ngOnInit(): void {
  }

}
