import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { VParticular } from '../models/vparticular.model';

@Injectable()
export class VParticularService {

  constructor(private http: HttpClient) {}

  getVParticularUnico() : Observable<VParticular[]> {
    return this.http.get<VParticular[]>(environment.API_URL + 'vparticulares');
  }

  getVParticularData(id:number) : Observable<VParticular> {
    return this.http.get<VParticular>(environment.API_URL + 'vparticulares/' + id);
  }
}
