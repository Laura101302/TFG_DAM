import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PParticular } from 'src/app/models/pparticular.model';
import { PParticularService } from 'src/app/services/pparticular.service';

@Component({
  selector: 'app-productos-particulares',
  templateUrl: './productos-particulares.component.html',
  styleUrls: ['./productos-particulares.component.css']
})
export class ProductosParticularesComponent implements OnInit {

  pparticular: PParticular | null;
  id: number;

  constructor(private _pparticularService: PParticularService, private _activatedRoute: ActivatedRoute) {
    this.pparticular = null;
    this.id = 0;
  }

  ngOnInit(): void {
    this._activatedRoute.paramMap.subscribe((parameters: any) => {
      this.id = parameters.get('id');
      this._pparticularService.getPParticularData(this.id).subscribe((x) => (this.pparticular = x));
      this.pparticular = parameters;
    })
  }
}
