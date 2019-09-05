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
    MatProgressBarModule
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
    MatProgressBarModule
  ],
  declarations: []
})
export class MaterialModule { }
