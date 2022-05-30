import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PParticular } from '../models/pparticular.model';

@Injectable()
export class PParticularService {

  constructor(private http: HttpClient) {}

  getPParticularUnico() : Observable<PParticular[]> {
    return this.http.get<PParticular[]>(environment.API_URL + 'pparticulares');
  }

  getPParticularData(id:number) : Observable<PParticular> {
    return this.http.get<PParticular>(environment.API_URL + 'pparticulares/' + id);
  }
}
