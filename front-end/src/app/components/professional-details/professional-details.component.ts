import { Component, OnInit, Input } from '@angular/core';
import { Professional } from 'src/app/shared/models/professional';
import { Cities } from 'src/app/shared/models/cities';
import { UserService } from 'src/app/shared/services/user.service';
import { ActivatedRoute, Router } from '@angular/router';
import { User } from 'src/app/shared/models/user';
import { Recommendation } from 'src/app/shared/models/recommendation';
import { RecommendationService } from 'src/app/shared/services/recommendation.service';
import { RecForProf } from 'src/app/shared/models/RecForProf';

@Component({
  selector: 'app-professional-details',
  templateUrl: './professional-details.component.html',
  styleUrls: ['./professional-details.component.css']
})
export class ProfessionalDetailsComponent implements OnInit {

  resultRecommendationList:Recommendation[];
  showRec:Boolean=false;
  @Input() professional:RecForProf   
  
  constructor(private recService:RecommendationService,private userService:UserService,private router:Router) {
    
  }
  ngOnInit() {

  }

 showHideRec()
 {
   
   if(!this.userService.getcurrentUser)
   this.router.navigate(['login']);//לתת הודעה שחייבים להכנס??//להחזיר בחזרה לדף
   this.showRec=!this.showRec;
   if(this.showRec==true)
   {
   this.recService.getRecommendationsOfProf(this.professional.Professional.UserId).subscribe(
    (result)=>{ this.setRecommendationList(result)}   
  )

}
 }
 getRecommendationList()
  {
    return this.resultRecommendationList;
  }

  setRecommendationList(recommendation:Recommendation[])
  {
    this.resultRecommendationList=recommendation;
  }
}
