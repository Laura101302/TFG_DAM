import { Component } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.css'],
  providers: [NgbCarouselConfig]
})
export class InicioComponent {

  images1: Array<String>;
  images2: Array<String>;

  showNavigationArrows = false;
  showNavigationIndicators = false;

  constructor(config: NgbCarouselConfig) {
    config.showNavigationArrows = true;
    config.showNavigationIndicators = true;
    this.images1 = ['altavoz', 'lampara', 'mesa'].map((n) => `/assets/images/mayoristas/${n}.jpg`);
    this.images2 = ['camiseta', 'pantalon', 'piano'].map((n) => `/assets/images/particulares/${n}.jpg`);
  }

  ngOnInit(): void {
  }
}
