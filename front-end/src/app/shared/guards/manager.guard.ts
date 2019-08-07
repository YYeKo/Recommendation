import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { UserService } from '../services/user.service';

@Injectable({
  providedIn: 'root'
})
export class ManagerGuard implements CanActivate {
  constructor(private userServ:UserService,private router:Router){}
  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
      debugger
     this.userServ.getProfessionalById(this.userServ.getcurrentUser()).subscribe(
      (res)=>{
        debugger
        if(res.IsManager==true)
      return true;
      return false;
      }
      )
    return;//?????????????????????????????????????????????????
  }
  
}
