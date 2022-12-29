import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DoctorComponent } from '../doctor/doctor.component';
import { HomeComponent } from './home.component';

const routes: Routes = [
  {
    path:"", component:HomeComponent ,children:
    [
      {
        path:"", redirectTo:"#", pathMatch:"full"
      },
      {
        path:"#", component:HomeComponent
      },
      {
        path:"doctor", component:DoctorComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
