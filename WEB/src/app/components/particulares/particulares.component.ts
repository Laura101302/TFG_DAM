import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-particulares',
  templateUrl: './particulares.component.html',
  styleUrls: ['./particulares.component.css']
})
export class ParticularesComponent implements OnInit {

  images = ['camiseta', 'pantalon', 'piano', 'portatil', 'sudadera'].map((n) => `/assets/images/particulares/${n}.jpg`);

  constructor() { }

  ngOnInit(): void {
  }

}
