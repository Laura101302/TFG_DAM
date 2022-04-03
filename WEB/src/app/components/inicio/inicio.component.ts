import { Component } from '@angular/core';
import { NgbCarouselConfig } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.css'],
  providers: [NgbCarouselConfig]
})
export class InicioComponent {

  showNavigationArrows = false;
  showNavigationIndicators = false;
  images1 = ['altavoz', 'lampara', 'mesa'].map((n) => `/assets/images/mayoristas/${n}.jpg`);
  images2 = ['camiseta', 'pantalon', 'piano'].map((n) => `/assets/images/particulares/${n}.jpg`);

  constructor(config: NgbCarouselConfig) {
    config.showNavigationArrows = true;
    config.showNavigationIndicators = true;
  }

  ngOnInit(): void {
  }
}
