import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PMayorista } from '../models/pmayorista.model';

@Injectable()
export class PMayoristaService {

  constructor(private http: HttpClient) {}

  getPMayorista(): Observable<PMayorista[]> {
    return this.http.get<PMayorista[]>(environment.API_URL + 'pmayoristas');
  }

  getPMayoristaData(id:number) : Observable<PMayorista> {
    return this.http.get<PMayorista>(environment.API_URL + 'pmayoristas/' + id);
  }
}
