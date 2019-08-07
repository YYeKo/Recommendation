import { Component, OnInit } from '@angular/core';
import { Cities } from 'src/app/shared/models/cities';
import { User } from 'src/app/shared/models/user';
import { UserService } from 'src/app/shared/services/user.service';

@Component({
  selector: 'app-user-details',
  templateUrl: './user-details.component.html',
  styleUrls: ['./user-details.component.css']
})
export class UserDetailsComponent implements OnInit {

  user:User=new User();
  cityList:Cities[];

  constructor(private service:UserService) { }

  ngOnInit() {
    this.service.getCities().subscribe(
  cl=>this.cityList=cl);
  }
  
  check()
  {
     this.service.registerUser(this.user).subscribe(
      result=>{
      if(result)
      
      alert("register user success");
     
      else alert(
        "register user failed");
    }
    )
  }
}
