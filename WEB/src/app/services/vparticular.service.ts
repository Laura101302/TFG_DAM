import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { VParticular } from '../models/vparticular.model';

@Injectable()
export class VParticularService {
  constructor(private http: HttpClient) {}
  getVParticularData() : Observable<VParticular[]> {
    return this.http.get<VParticular[]>(environment.API_URL + 'vparticulares');
  }

  postVParticularData(body : any) : VParticular {
    let bodyData =new VParticular();
    bodyData.nombrecompleto=body.vparticularNombreCompleto;
    bodyData.informacion=body.vparticularInformacion;
    bodyData.dni=body.vparticularDNI;


    let result =new VParticular();
    this.http.post<VParticular>(environment.API_URL + 'vparticulares',bodyData)
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
