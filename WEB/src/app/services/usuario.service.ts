import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Usuario } from '../models/usuario.model';

@Injectable()
export class UsuarioService {
  constructor(private http: HttpClient) {}
  getUsuarioData() : Observable<Usuario[]> {
    return this.http.get<Usuario[]>(environment.API_URL + 'usuarios');
  }

  postUsuarioData(body : any) : Usuario {
    let bodyData =new Usuario();
    bodyData.nombrecompleto=body.usuarioNombreCompleto;
    bodyData.contrasena=body.usuarioContrasena;
    bodyData.correoelectronico=body.usuarioCorreoElectronico;


    let result =new Usuario();
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
