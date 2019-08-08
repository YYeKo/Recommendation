import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Cities } from 'src/app/shared/models/cities';
import { UserService } from 'src/app/shared/services/user.service';
import {ProfessionService}  from 'src/app/shared/services/profession.service';
import { RecommendationService } from 'src/app/shared/services/recommendation.service';
import { Professional } from 'src/app/shared/models/professional';
import { Router } from '@angular/router';
import { Professions } from 'src/app/shared/models/professions';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})

export class SearchComponent implements OnInit {
  city:number;
  cityName:string;
  profession:number;
  professionName:string;
  professionList:Professions[];
  cityList:Cities[];
  ProfessionalList:Professional[];
 //===================
 filteredCities:Cities[];
 filteredProfessions:Professions[];
 myControl = new FormControl();
 
  constructor(private userService:UserService,private professionService:ProfessionService,private recommService:RecommendationService,private router:Router) { }

  ngOnInit() {
    debugger
    this.userService.getCities().subscribe(
      cl=>this.cityList=this.filteredCities=cl);
    this.professionService.getProfessions().subscribe(
      p=>
     { debugger;
      this.professionList=this.filteredProfessions=p});
  }

  search()
  {
    debugger
    this.cityList.forEach(element => {
      if(element.CityName==this.cityName)
      this.city=element.CityId;
    });
    this.professionList.forEach(element => {
      if(element.ProfessionName==this.professionName)
      this.profession=element.ProfessionId;
    });
    if(this.profession==undefined)
    {
      ///////
      debugger
    }
    this.recommService.setCity(this.cityName);
    this.recommService.setProfession(this.professionName);
    this.recommService.getFilteredProfessionals(this.profession,this.city).subscribe(
      (result)=>{ this.recommService.setResultlist(result)
        this.router.navigate(['searchResult']);}
     
    )
    
  }
  //================================
  searchCity(event)
  {
    this.filteredCities=this.cityList.filter(city=>city.CityName.startsWith(event)==true);
  }
  searchProfession(event)
  {
    this.filteredProfessions=this.professionList.filter(prof=>prof.ProfessionName.startsWith(event)==true);
  }
}