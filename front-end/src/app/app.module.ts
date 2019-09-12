import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './components/login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { HomeComponent } from './components/home/home.component';
import {UserDetailsComponent} from './components/user-details/user-details.component';
import { RegisterComponent } from './components/register/register.component';
import { SearchComponent } from './components/search/search.component';
import { SearchResultComponent } from './components/search-result/search-result.component';
import { ProfessionalDetailsComponent } from './components/professional-details/professional-details.component';
import { AddProfessionalComponent } from './components/add-professional/add-professional.component';
import { ShowRecommendationsComponent } from './components/show-recommendations/show-recommendations.component';
import { AddRecommendationComponent } from './components/add-recommendation/add-recommendation.component';
import { HeaderComponent } from './components/header/header.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { MaterialModule } from './material.module';
import {AddProfessionComponent} from './components/add-profession/add-profession.component';
import { LoadingComponent } from './components/loading/loading.component';
import { CommonModule } from '@angular/common';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    UserDetailsComponent,
    RegisterComponent,
    SearchComponent,
    SearchResultComponent,
    ProfessionalDetailsComponent,
    AddProfessionalComponent,
    ShowRecommendationsComponent,
    AddRecommendationComponent,
    HeaderComponent,
    AddProfessionComponent,
    LoadingComponent
  ],
  imports: [
    CommonModule,
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
