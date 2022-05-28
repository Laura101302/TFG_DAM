import { Component, OnInit } from '@angular/core';
import { PMayorista } from 'src/app/models/pmayorista.model';
import { PMayoristaService } from 'src/app/services/pmayorista.service';

@Component({
  selector: 'app-mayoristas',
  templateUrl: './mayoristas.component.html',
  styleUrls: ['./mayoristas.component.css']
})
export class MayoristasComponent implements OnInit {

  pmayorista: PMayorista[] | null;

  constructor(private _pmayoristaService: PMayoristaService) {
    this.pmayorista = null;
  }

  ngOnInit(): void {
    this._pmayoristaService
      .getPMayorista()
      .subscribe((x) => (this.pmayorista = x));
  }
}
