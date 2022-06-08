import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { cookieHelper } from 'src/app/helper/cookiehelper';
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
  isLogged: boolean;
  cookie: String | null;

  constructor(private _pparticularService: PParticularService, private _activatedRoute: ActivatedRoute, private _cookie: cookieHelper) {
    this.pparticular = null;
    this.id = 0;
    this.isLogged = true;
    this.cookie = null;
  }

  ngOnInit(): void {
    this._activatedRoute.paramMap.subscribe((parameters: any) => {
      this.id = parameters.get('id');
      this._pparticularService.getPParticularData(this.id).subscribe((x) => (this.pparticular = x));
      this.pparticular = parameters;
    })

    this.cookie = this._cookie.getCookie();
    if(this.cookie === null || this.cookie == ""){
      this.isLogged = false;
    }
  }

  eliminar(){
    try{
      this._pparticularService.deletePParticular(this.id).subscribe();
    }catch{
      console.log("No se ha podido eliminar");
    }
  }
}
