import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/shared/services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-profession',
  templateUrl: './add-profession.component.html',
  styleUrls: ['./add-profession.component.css']
})
export class AddProfessionComponent implements OnInit {

  profession:string;
  
  constructor(private userServ:UserService,private router:Router) { }

  ngOnInit() {
    this.userServ.getProfessionalById(this.userServ.getcurrentUser()).subscribe(
      (res)=>{
        debugger
        if(res.IsManager!=true)
      this.router.navigate(['/home']);
      });
///?????????????????????????????????????????
    }
}
