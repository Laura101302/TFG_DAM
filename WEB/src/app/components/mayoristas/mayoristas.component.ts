import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-mayoristas',
  templateUrl: './mayoristas.component.html',
  styleUrls: ['./mayoristas.component.css']
})
export class MayoristasComponent implements OnInit {

  images = ['altavoz', 'lampara', 'mesa', 'monitor', 'silla'].map((n) => `/assets/images/mayoristas/${n}.jpg`);

  constructor() { }

  ngOnInit(): void {
  }

}
