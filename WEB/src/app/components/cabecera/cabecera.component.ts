import { Component, OnInit } from '@angular/core';
import { cookieHelper } from 'src/app/helper/cookiehelper';

@Component({
  selector: 'app-cabecera',
  templateUrl: './cabecera.component.html',
  styleUrls: ['./cabecera.component.css']
})
export class CabeceraComponent implements OnInit {

  nombre: String | null;
  isLogged: boolean;

  constructor(private _cookie: cookieHelper) {
    this.nombre = null;
    this.isLogged = true;
  }

  ngOnInit(): void {
    this.nombre = this._cookie.getCookie();
    if(this.nombre == null || this.nombre == ""){
      this.isLogged = false;
    }
  }

  cerrarSesion(){
    this._cookie.closeToken();
    window.location.reload();
  }
}
