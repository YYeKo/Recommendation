import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Professions } from '../models/professions';
import { HttpClient } from '@angular/common/http';


const BaseUrl="http://localhost:64775/api/professions";

@Injectable({
  providedIn: 'root'
})


export class ProfessionService {
  
  constructor(private http:HttpClient) { }

  getProfessions(): Observable<Professions[]> {
    debugger
    return this.http.get<Professions[]>(BaseUrl+'/getProfessions')
  }
}
