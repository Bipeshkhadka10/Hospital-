import { Component, OnInit } from '@angular/core';
import { Doctor } from '../Model/doctorModel';
import { ApiService } from '../Service/api.service';

@Component({
  selector: 'app-doctor',
  templateUrl: './doctor.component.html',
  styleUrls: ['./doctor.component.css']
})
export class DoctorComponent implements OnInit{
  doctor:Doctor= new Doctor();
 

  
   
  constructor( private apiservice:ApiService) { }


  ngOnInit(): void {
    
   
  }
  addDoctor(){
    this.apiservice.postDoctor(this.doctor).subscribe(
      
    );
  }
   
  

}
