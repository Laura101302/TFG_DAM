import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PParticular } from '../models/pparticular.model';

@Injectable()
export class PParticularService {
  constructor(private http: HttpClient) {}
  getPParticularData() : Observable<PParticular[]> {
    return this.http.get<PParticular[]>(environment.API_URL + 'pparticulares');
  }

  postPParticularData(body : any) : PParticular {
    let bodyData =new PParticular();
    bodyData.nombre=body.pparticularNombre;
    bodyData.precio=body.pparticularPrecio;
    bodyData.descripcion=body.pparticularDescipcion;
    bodyData.imagen=body.pparticularImagen;
    bodyData.dnivendedor=body.pparticularDNIVendedor;


    let result =new PParticular();
    this.http.post<PParticular>(environment.API_URL + 'pparticulares',bodyData)
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
