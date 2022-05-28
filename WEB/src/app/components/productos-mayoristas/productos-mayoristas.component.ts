import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
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
  // nombre: string | null;
  // precio: number;
  // descripcion: string | null;
  // imagen: string | null;


  constructor(private _pmayoristaService: PMayoristaService, private activatedRoute: ActivatedRoute) {
    this.pmayorista = null;
    this.id = 0;
    // this.nombre = null;
    // this.precio = 0;
    // this.descripcion = null;
    // this.imagen = null;
  }

  ngOnInit(): void {
    this.activatedRoute.paramMap.subscribe((parameters:any) => {
      this.id = parameters.get('id');
      console.log(this.id)
      this._pmayoristaService.getPMayoristaData(this.id).subscribe((x) => (this.pmayorista = x));
      this.pmayorista = parameters;
    });
  }
}
