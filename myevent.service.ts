import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { flatten } from '@angular/compiler';
import { Router } from '@angular/router';
import { eventModel } from 'src/Models/eventModel';

@Injectable({
  providedIn: 'root'
})
export class MyeventService {
  public getApi:string="https://localhost:44351/api/Insertevent";

  constructor(private http:HttpClient) { }
  
  getEvents():Observable<Array<eventModel>>{
    return this.http.get<Array<eventModel>>(this.getApi);
  }
}
