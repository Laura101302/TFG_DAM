import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Usuario } from '../models/usuario.model';

@Injectable()
export class UsuarioService {

  constructor(private http: HttpClient) {}

  getUsuarioData(correo: String) : Observable<Usuario> {
    return this.http.get<Usuario>(environment.API_URL + 'usuarios/'+correo);
  }

  postUsuarioData(body : any) : Usuario {
    let bodyData = new Usuario();
    bodyData.nombreCompleto=body.nombre;
    bodyData.contrasena=body.contra;
    bodyData.correoElectronico=body.correo;


    let result = new Usuario();
    this.http.post<Usuario>(environment.API_URL + 'usuarios',bodyData)
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
