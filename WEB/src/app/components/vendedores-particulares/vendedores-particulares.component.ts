import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { VParticular } from 'src/app/models/vparticular.model';
import { VParticularService } from 'src/app/services/vparticular.service';

@Component({
  selector: 'app-vendedores-particulares',
  templateUrl: './vendedores-particulares.component.html',
  styleUrls: ['./vendedores-particulares.component.css']
})
export class VendedoresParticularesComponent implements OnInit {

  vparticular: VParticular | null;
  id: number;

  constructor(private _vparticularService: VParticularService, private _activatedRoute: ActivatedRoute) {
    this.vparticular = null;
    this.id = 0;
  }

  ngOnInit(): void {
    this._activatedRoute.paramMap.subscribe((parameters: any) => {
      this.id = parameters.get('id');
      this._vparticularService.getVParticularData(this.id).subscribe((x) => this.vparticular = x);
      this.vparticular = parameters;
    })
  }
}
