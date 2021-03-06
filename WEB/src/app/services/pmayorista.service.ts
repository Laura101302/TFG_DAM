import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PMayorista } from '../models/pmayorista.model';

@Injectable()
export class PMayoristaService {

  constructor(private _http: HttpClient) {}

  getPMayorista(): Observable<PMayorista[]> {
    return this._http.get<PMayorista[]>(environment.API_URL + 'pmayoristas');
  }

  getPMayoristaData(id:number) : Observable<PMayorista> {
    return this._http.get<PMayorista>(environment.API_URL + 'pmayoristas/' + id);
  }

  deletePMayorista(id:number) : Observable<PMayorista> {
    return this._http.delete<PMayorista>(environment.API_URL + 'pmayoristas/' + id);
  }
}
