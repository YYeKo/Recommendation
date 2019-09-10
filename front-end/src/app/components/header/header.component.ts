import { Component, OnInit, Attribute } from '@angular/core';
import { Router } from '@angular/router';
import { UserService } from 'src/app/shared/services/user.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  
  constructor(private route:Router,private userServ:UserService) {
   }

  ngOnInit() {
  }
  getcurrentUser()
  {
  return this.userServ.getcurrentUser();
  }
  navigate()
  {
    this.route.navigate(['editProfessional',this.getcurrentUser()])
  }
  logOut()
  {
    localStorage.clear();
    this.route.navigate(['home']);
    }
  getuserName()
  {
return this.userServ.getuserName();
  }
  
}