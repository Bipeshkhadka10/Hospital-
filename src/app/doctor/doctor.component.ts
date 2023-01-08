import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/Service/api.service';
import { Doctor } from 'src/app/Model/doctorModel';
import { ParseTreeResult } from '@angular/compiler';



@Component({
  selector: 'app-doctor',
  templateUrl: './doctor.component.html',
  styleUrls: ['./doctor.component.css']
})
export class DoctorComponent implements OnInit{
  doctor:Doctor=new Doctor();
  // doctorlist:any;
  // doctorRow:any;
  // isDoctorSelected:boolean=false;
  // doctorId:number=0;
  constructor(private _apiService:ApiService) { }
  


  ngOnInit(): void {
 
  }


  addDoctor(){
    this._apiService.postDoctor(this.doctor).subscribe(
      
      

      
      
    )
      
    
  }
 
  
}
