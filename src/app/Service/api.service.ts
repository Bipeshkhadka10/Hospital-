import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Doctor } from '../Model/doctorModel';



@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private _http:HttpClient) { }

  postDoctor(doctorParam:Doctor):Observable<any>{
    return this._http.post("https://localhost:7278/api/Doctor",doctorParam,{responseType:'json'});
    
  }
}
