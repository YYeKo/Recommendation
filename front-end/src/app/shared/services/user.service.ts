import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { User } from '../models/user';
import { Cities } from '../models/cities';
import { Professional } from '../models/professional';
import { Professions } from '../models/professions';

const BaseUrl="http://localhost:64775/api/user";

@Injectable({
  providedIn: 'root'
})
export class UserService {
  getProfessionalNameById(id: number) {
    return this.http.get<string>(BaseUrl+'/getProfessionalNameById/'+id);
  }
  
  constructor(private http:HttpClient) { }

  logIn(userName,userPassword):Observable<number>
  {
    console.log(BaseUrl)
   return this.http.get<number>(`${BaseUrl}/LogIn/${userName}/${userPassword}`)
  }

  registerUser(user:User):Observable<boolean>
  {
    return this.http.post<boolean>(`${BaseUrl}/registerUser`,user)
  }

  registerProfessional(professional:Professional):Observable<boolean>
  {
    return this.http.post<boolean>(`${BaseUrl}/registerProfessional`,professional)
    // return this.http.post<boolean>(`${BaseUrl}/registerProfessional`,{profesional:professional,subject:profession})

  }

  getCities():Observable<Cities[]>
  {
    return this.http.get<Cities[]>(BaseUrl+'/getCities')
  }

  getProfessionals():Observable<Professional[]>
  {
    return this.http.get<Professional[]>(BaseUrl+'/getProfessionals')
  }

  getProfessionalById(id):Observable<Professional>
  {
    //console.log(BaseUrl+'/getProfessionalById/'+id)
    return this.http.get<Professional>(BaseUrl+'/getProfessionalById/'+id);
  }
  
  getcurrentUser()
  {
  return localStorage.getItem("userId");
  }

  getuserName()
  {
  return localStorage.getItem("userName");
  }

}
