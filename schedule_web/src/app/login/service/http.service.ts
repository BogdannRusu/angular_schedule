import { HttpClient } from '@angular/common/http';
import { Injectable, inject } from '@angular/core';
import { IProfesori } from '../interfaces/profesori';
import { ICabinete } from '../interfaces/cabinete';
import { IGrupe } from '../interfaces/grupe';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  
  apiUrl = "https://localhost:7060";
  http=inject(HttpClient)
  constructor(){}

  getAllProfesori(){
   return this.http.get<IProfesori[]>(this.apiUrl + "/api/Profesori")
  }

  getAllCabinete(){
    return this.http.get<ICabinete[]>(this.apiUrl + "/api/Cabinete")
   }

   getAllGrupe(){
    return this.http.get<IGrupe[]>(this.apiUrl + "/api/Grupe")
   }

}
