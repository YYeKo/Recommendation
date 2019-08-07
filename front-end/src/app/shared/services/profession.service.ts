import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Professions } from '../models/professions';
import { HttpClient } from '@angular/common/http';
import { Specializations } from '../models/specializations';

const BaseUrl="http://localhost:64775/api/professions";

@Injectable({
  providedIn: 'root'
})


export class ProfessionService {
  
  constructor(private http:HttpClient) { }

  getProfessions(): Observable<Specializations[]> {
    return this.http.get<Specializations[]>(BaseUrl+'/getProfessions')
  }
}
