import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatButtonModule,MatFormFieldModule,MatSliderModule,MatTableModule,MatRadioModule, MatInputModule,MatAutocompleteModule, MatRippleModule,MatSelectModule,MatIconModule, MatCardModule} from '@angular/material';
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
    MatCardModule
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
    MatCardModule
  ],
  declarations: []
})
export class MaterialModule { }
