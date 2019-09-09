import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Recommendation } from '../models/recommendation';
import { Professional } from '../models/professional';
import { Professions } from '../models/professions';
import { RecForProf } from '../models/RecForProf';

const BaseUrl="http://localhost:64775/api/recommendation";
@Injectable({
  providedIn: 'root'
})
export class RecommendationService {
  
  city:string;
  profession:string;
  ProfessionalList:RecForProf[];
  
  constructor(private http:HttpClient) { }

  createRecommendation(recommendation:Recommendation):Observable<boolean>
  {
    return this.http.post<boolean>(`${BaseUrl}/createRecommendation`,recommendation)
  }

  getFilteredProfessionals(profession: any, city: any):Observable<RecForProf[]>
  {
     return this.http.get<RecForProf[]>(`${BaseUrl}/getFilteredProfessionals/${profession}/${city}`)
  }
  // getFilteredProfessionals(profession: any, city: any){
  //   debugger
  //    this.http.get<Professional[]>(`${BaseUrl}/getFilteredProfessionals/${profession}/${city}`).subscribe(
       
  //     (result)=>{this.ProfessionalList=result
  //    }
  //   )
  // }
  getResultList()
  {
    return this.ProfessionalList;
  }

  setResultlist(professionals:RecForProf[])
  {
    this.ProfessionalList=professionals;
  }
  
  getRecommendationsOfProf(id):Observable<Recommendation[]>
  {
    debugger
return this.http.get<Recommendation[]>(`${BaseUrl}/getRecommendationsOfProf/${id}`);
  }
  getCity()
  {
    return this.city;
  }

  setCity(city:string)
  {
    this.city=city;
  }

  getProfession()
  {
    return this.profession;
  }

  setProfession(profession:string)
  {
    this.profession=profession;
  }
}
