import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from "@angular/router";
import { UserService } from 'src/app/shared/services/user.service';
import { NgForm } from '@angular/forms';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  isFailure:Boolean=false;
  @ViewChild('userModelForm') form:NgForm;
  constructor(private service:UserService,private router:Router ) {
  }
  ngOnInit() {
     if(this.service.getcurrentUser()!=null)
     this.router.navigate(['home']);
  }
  LogIn(userName,userPassword)
  {   
    this.service.logIn(userName,userPassword).subscribe(
      (result:number)=>{
          if(result!=0)
          {
            localStorage.setItem("userId",result.toString())
            localStorage.setItem("userName",userName);
            this.router.navigate(['home']);
          }
          else
          {
            console.log("user does not exists navigate to register");
            this.isFailure=true;///או 
            this.form.reset();
            //this.router.navigate(['register']);
          }
      }
    )
  }
  RemoveMessege()
  {
    this.isFailure=false;
  }

}
