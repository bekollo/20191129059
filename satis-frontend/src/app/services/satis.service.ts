import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { environment } from 'src/environments/environment';
import { SatisRequestModel, GetSatissResponseModel } from '../models/satis.model';

@Injectable({ providedIn: 'root' })
export class SatisService {
  satiss$ = this.http.get<GetSatissResponseModel>(environment.api + 'Post');

  constructor(
    private http: HttpClient
  ) { }

  createPost(request: SatisRequestModel) {
    return this.http.post(environment.api + 'post', request);
  }

}
