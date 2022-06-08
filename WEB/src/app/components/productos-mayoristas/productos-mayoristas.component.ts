import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { cookieHelper } from 'src/app/helper/cookiehelper';
import { PMayorista } from 'src/app/models/pmayorista.model';
import { PMayoristaService } from 'src/app/services/pmayorista.service';

@Component({
  selector: 'app-productos-mayoristas',
  templateUrl: './productos-mayoristas.component.html',
  styleUrls: ['./productos-mayoristas.component.css']
})
export class ProductosMayoristasComponent implements OnInit {

  pmayorista: PMayorista | null;
  id: number;
  isLogged: boolean;
  cookie: String | null;

  constructor(private _pmayoristaService: PMayoristaService, private _activatedRoute: ActivatedRoute, private _cookie: cookieHelper) {
    this.pmayorista = null;
    this.id = 0;
    this.isLogged = true;
    this.cookie = null;
  }

  ngOnInit(): void {
    this._activatedRoute.paramMap.subscribe((parameters:any) => {
      this.id = parameters.get('id');
      this._pmayoristaService.getPMayoristaData(this.id).subscribe((x) => (this.pmayorista = x));
      this.pmayorista = parameters;
    });

    this.cookie = this._cookie.getCookie()
    if(this.cookie === null || this.cookie == ""){
      this.isLogged = false;
    }
  }

  eliminar(){
    try{
      this._pmayoristaService.deletePMayorista(this.id).subscribe();
    }catch{
      console.log("No se ha podido eliminar");
    }
  }
}
