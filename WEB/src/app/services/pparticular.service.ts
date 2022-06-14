import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { PParticular } from '../models/pparticular.model';

@Injectable()
export class PParticularService {

  constructor(private _http: HttpClient) {}

  getPParticular() : Observable<PParticular[]> {
    return this._http.get<PParticular[]>(environment.API_URL + 'pparticulares');
  }

  getPParticularData(id:number) : Observable<PParticular> {
    return this._http.get<PParticular>(environment.API_URL + 'pparticulares/' + id);
  }

  deletePParticular(id:number) : Observable<PParticular> {
    return this._http.delete<PParticular>(environment.API_URL + 'pparticulares/' + id);
  }
}
