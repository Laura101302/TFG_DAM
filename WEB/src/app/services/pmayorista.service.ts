import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PMayorista } from '../models/pmayorista.model';

@Injectable()
export class PMayoristaService {
  constructor(private http: HttpClient) {}
  getPMayoristaData() : Observable<PMayorista[]> {
    return this.http.get<PMayorista[]>(environment.API_URL + 'pmayoristas');
  }

  postPMayoristaData(body : any) : PMayorista {
    let bodyData =new PMayorista();
    bodyData.nombre=body.pmayoristaNombre;
    bodyData.precio=body.pmayoristaPrecio;
    bodyData.descripcion=body.pmayoristaDescripcion;
    bodyData.imagen=body.pmayoristaImagen;


    let result =new PMayorista();
    this.http.post<PMayorista>(environment.API_URL + 'pmayoristas',bodyData)
    .subscribe(
      (response) => {
        console.log('response received')
        result = response;
      },
      (error) => {
        console.error('error caught in component')
      }
    )
    return result;
  }
}
