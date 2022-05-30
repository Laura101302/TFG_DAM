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

  constructor(private _pmayoristaService: PMayoristaService, private _activatedRoute: ActivatedRoute) {
    this.pmayorista = null;
    this.id = 0;
  }

  ngOnInit(): void {
    this._activatedRoute.paramMap.subscribe((parameters:any) => {
      this.id = parameters.get('id');
      console.log(this.id);
      this._pmayoristaService.getPMayoristaData(this.id).subscribe((x) => (this.pmayorista = x));
      this.pmayorista = parameters;
    });
  }

  onSubmit(id:number){
    this.eliminar(id);
  }

  eliminar(id: number){
    try{
      this._pmayoristaService.deletePMayorista(id);
    }catch{
      console.log("No se ha podido eliminar");
    }
  }
}
