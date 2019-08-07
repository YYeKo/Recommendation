import { Component, OnInit, Input } from '@angular/core';
import { Recommendation } from 'src/app/shared/models/recommendation';
import { RecommendationService } from 'src/app/shared/services/recommendation.service';
import { UserService } from 'src/app/shared/services/user.service';
import { Professional } from 'src/app/shared/models/professional';
import { ActivatedRoute } from '@angular/router';
import { projection } from '@angular/core/src/render3/instructions';

@Component({
  selector: 'app-add-recommendation',
  templateUrl: './add-recommendation.component.html',
  styleUrls: ['./add-recommendation.component.css']
})
export class AddRecommendationComponent implements OnInit {


  currentUser:string;
  recommendation:Recommendation=new Recommendation();
  // professionalList:Professional[];
  professionalName:string;
  professionalId:number;
  constructor(private service:RecommendationService,private userService:UserService,private activatedRoute: ActivatedRoute) {

    this.activatedRoute.params.subscribe(params => 
      {
        this.professionalId=params['id'];
      this.userService.getProfessionalNameById(params['id']).subscribe((res) => {this.professionalName=res})})
   }
  
  ngOnInit(){
    // להמלצה על בעל מקצוע אחר
    // this.userService.getProfessionals().subscribe(
    //   pl=>{
    //     this.professionalList=pl;
    //   }
    // )
    this.currentUser=this.userService.getuserName();
  }
  addRecommendation()
  {
    debugger
    this.recommendation.UserId=parseInt(this.userService.getcurrentUser());
    this.recommendation.Professional=this.professionalId;
     this.service.createRecommendation(this.recommendation).subscribe(
      result=>{
      if(result)
      
      alert("createRecommendation success");     
      else alert("createRecommendation failed");
    }
    )
  }
}
