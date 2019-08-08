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
    MatExpansionModule
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
    MatExpansionModule
  ],
  declarations: []
})
export class MaterialModule { }
