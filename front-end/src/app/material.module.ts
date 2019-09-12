import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatButtonModule,
  MatFormFieldModule,
  MatSliderModule,
  MatExpansionModule,
  MatTableModule,
  MatRadioModule,
   MatInputModule,
   MatAutocompleteModule,
    MatRippleModule,
    MatSelectModule,
    MatIconModule,
    MatProgressBarModule,
    MatListModule,
     MatCardModule} from '@angular/material';
import {MatCheckboxModule} from '@angular/material/checkbox';


@NgModule({
  imports: [
    CommonModule,
    MatButtonModule,
    MatCheckboxModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatRippleModule,
    MatSelectModule,
    MatIconModule,
    MatAutocompleteModule,
    MatTableModule,
    MatRadioModule,
    MatSliderModule,
    MatCardModule,
    MatExpansionModule,
    MatProgressBarModule,
    MatListModule
  ],
  exports:[
    MatButtonModule,
    MatCheckboxModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatRippleModule,
    MatSelectModule,
    MatIconModule,
    MatAutocompleteModule,
    MatTableModule,
    MatRadioModule,
    MatSliderModule,
    MatCardModule,
    MatExpansionModule,
    MatProgressBarModule,
    MatListModule
  ],
  declarations: []
})
export class MaterialModule { }
//::ng-deep.mat-icon{}