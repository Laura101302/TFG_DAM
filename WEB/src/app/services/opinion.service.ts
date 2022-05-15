import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Opinion } from '../models/opinion.model';

@Injectable()
export class OpinionService {
  constructor(private http: HttpClient) {}
  getOpinionData() : Observable<Opinion[]> {
    return this.http.get<Opinion[]>(environment.API_URL + 'opiniones');
  }

  postOpinionData(body : any) : Opinion {
    let bodyData =new Opinion();
    bodyData.nombre=body.opinionNombre;
    bodyData.apellidos=body.opinionApellidos;
    bodyData.telefono=body.opinionTelefono;
    bodyData.comentario=body.opinionComentario;
    bodyData.calificacion=body.opinionCalificacion;
    bodyData.correoelectronico=body.opinionCorreoElectronico;


    let result =new Opinion();
    this.http.post<Opinion>(environment.API_URL + 'opiniones',bodyData)
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
