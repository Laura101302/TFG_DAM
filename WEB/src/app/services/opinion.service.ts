import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Opinion } from '../models/opinion.model';

@Injectable()
export class OpinionService {

  constructor(private _http: HttpClient) {}

  //Muestra las opiniones que hay en la base de datos
  getOpinionData() : Observable<Opinion[]> {
    return this._http.get<Opinion[]>(environment.API_URL + 'opiniones');
  }

  postOpinionData(body : any, rate : number) : Opinion {
    let bodyData =new Opinion();
    bodyData.nombre = body.Nombre;
    bodyData.apellidos = body.Apellidos;
    bodyData.correoElectronico = body.CorreoElectronico;
    bodyData.telefono = body.Telefono;
    bodyData.comentario = body.Comentario;
    bodyData.calificacion = rate;
    console.log(bodyData);



    let result = new Opinion();
    this._http.post<Opinion>(environment.API_URL + 'opiniones',bodyData)
    .subscribe(
      (response) => {
        console.log('response received')
        result = response;
        window.location.reload();
      },
      (error) => {
        console.error('error caught in component')
      }
    )
    return result;
  }
}
