import { Component, OnInit, Input } from '@angular/core';
import { Recommendation } from 'src/app/shared/models/recommendation';
import { UserService } from 'src/app/shared/services/user.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-show-recommendations',
  templateUrl: './show-recommendations.component.html',
  styleUrls: ['./show-recommendations.component.css']
})
export class ShowRecommendationsComponent implements OnInit {

  @Input() recommendation:Recommendation
  constructor(private userServ:UserService,private router:Router) { }

  ngOnInit() {
    if(this.userServ.getcurrentUser()==null)
this.router.navigate(['/Login']);
  }


}
