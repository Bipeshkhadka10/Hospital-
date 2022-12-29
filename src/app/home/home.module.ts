import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { DoctorComponent } from '../doctor/doctor.component';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';



@NgModule({
  declarations: [
    HomeComponent,
    DoctorComponent    
    
  ],
  imports: [
    CommonModule,
    HomeRoutingModule,
    FormsModule
    
  ],
  providers: [],
  bootstrap: [HomeComponent]
})
export class HomeModule { }
