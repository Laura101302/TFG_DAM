import { Component, OnInit } from '@angular/core';
import { PParticular } from 'src/app/models/pparticular.model';
import { PParticularService } from 'src/app/services/pparticular.service';

@Component({
  selector: 'app-particulares',
  templateUrl: './particulares.component.html',
  styleUrls: ['./particulares.component.css']
})
export class ParticularesComponent implements OnInit {

  pparticular: PParticular[] | null;

  constructor(private _pparticularService: PParticularService) {
    this.pparticular = null;
  }

  ngOnInit(): void {
    this._pparticularService
      .getPParticular()
      .subscribe((x) => (this.pparticular = x));
  }
}
