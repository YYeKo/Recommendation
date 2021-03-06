import { Component, OnInit, Input } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/shared/services/user.service';
import { Professional } from 'src/app/shared/models/professional';
import { Cities } from 'src/app/shared/models/cities';
import { User } from 'src/app/shared/models/user';
import { Validators, FormControl, FormGroup, FormBuilder } from '@angular/forms';
import {Observable} from 'rxjs';
import {map, startWith} from 'rxjs/operators';
import { Professions } from 'src/app/shared/models/professions';
import { ProfessionService } from 'src/app/shared/services/profession.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  
  //  @Input() Professions:Professions
  selectedOptions:Professions[];
  isProfessional=false;
  hide = true;
  professional: User;
  profession:Professions;
  cityList: Cities[];
 title:Boolean=true;
 professionList:Professions[];
 //------------------------
 email = new FormControl('', [Validators.required, Validators.email]);
  filteredCities: Cities[];
  
  constructor(private service: UserService,private professionService:ProfessionService, private activatedRoute: ActivatedRoute,private router: Router,private formBuilder: FormBuilder) { 
    
    this.activatedRoute.params.subscribe(params => 
      {
        if(params['id']!=null)
        {
      this.service.getProfessionalById(params['id']).subscribe((res) => {
        debugger
        this.professional=res;
        console.log(res)
        if(res.ProfessionalId!=undefined)
        {
        this.setProfessional();
        this.title=false;
        }
        else {
          this.isProfessional=false;
        }
      }, (err) => {
        this.router.navigate(['register'])
      })}
      else this.professional=new Professional();
    });
  }
   
  checkIfProfessional():boolean
  {
    return this.isProfessional
  } 

  setProfessional()
  {
    this.isProfessional=!this.isProfessional;
  }
  ngOnInit() {

    this.service.getCities().subscribe(
      cl => this.filteredCities=this.cityList = cl);
      this.professionService.getProfessions().subscribe(
        p=>
       {
          debugger;
        this.professionList=p;
      });
  }
  register() {
    debugger
    if(this.checkIfProfessional()){
    (this.professional as Professional).professions=this.selectedOptions;
    this.service.registerProfessional(this.professional).subscribe(
      
     (res) => {      
        if (res)
        {
             alert("register success");
            this.router.navigate(['home']);
        }
        else {
          alert("register failed");
        }       
      }),(err)=>{
        alert(err);
      }
    }
    else
    {
      debugger
      this.service.registerUser(this.professional).subscribe(
        (res) => {
          
           if (res)
           {
                alert("register success");
               this.router.navigate(['home']);
           }
           else {
             alert("register failed");
           }          
         },(err)=>{alert("סיסמא בשימוש");
         })     
    }
  }
  //error messege email angular material
  getErrorMessage() {
    return this.email.hasError('required') ? 'שדה חובה' :
        this.email.hasError('email') ? 'כתובת מייל לא תקינה' : '';
  }
  //make the autoComplete of city list
  searchCity(event)
  {
    this.filteredCities=this.cityList.filter(city=>city.CityName.startsWith(event)==true);
  }
//take the selected professions from the selection-list
  onSelection(e, v) {
    this.selectedOptions=[];
    for (let index = 0; index < v.length; index++) {
      this.selectedOptions.push(v[index].value);
    }
  }
}