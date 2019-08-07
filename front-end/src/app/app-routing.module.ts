import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { HomeComponent } from './components/home/home.component';
import { RegisterComponent } from './components/register/register.component';
import {SearchComponent} from './components/search/search.component';
import { AddProfessionalComponent } from './components/add-professional/add-professional.component';
import {AddRecommendationComponent} from './components/add-recommendation/add-recommendation.component';
import {ShowRecommendationsComponent} from './components/show-recommendations/show-recommendations.component';
import {ProfessionalDetailsComponent} from './components/professional-details/professional-details.component';
import {SearchResultComponent} from './components/search-result/search-result.component';
import {AddProfessionComponent} from './components/add-profession/add-profession.component';
import { from } from 'rxjs';
import { UserGuard } from './shared/guards/user.guard';
import { ManagerGuard } from './shared/guards/manager.guard';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {path:'Login',component:LoginComponent},
  {path:'home',component:HomeComponent},
  {path:'register',component:RegisterComponent},
  {path:'search',component:SearchComponent},
  {path:'editProfessional/:id',component:RegisterComponent},
  {path:'AddRecommendation/:id',component:AddRecommendationComponent,canActivate:[UserGuard]},
  {path:'ShowRecommendations',component:ShowRecommendationsComponent,canActivate:[UserGuard]},
  {path:'searchResult',component:SearchResultComponent},
  {path:'addProfession',component:AddProfessionComponent,canActivate:[UserGuard]},
  { path: '**', redirectTo: '' }
];
@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(routes) ,
  ],
  exports: [ RouterModule 
  ],
  declarations: []
})
export class AppRoutingModule {

  
 }
//  {path:'editProfessional/:id/:code',component:RegisterComponent},//שינוי
