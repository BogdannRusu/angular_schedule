import { Component } from '@angular/core';
import { HttpService } from '../../login/service/http.service';

@Component({
  selector: 'app-cabinete',
  templateUrl: './cabinete.component.html',
  styleUrl: './cabinete.component.css'
})
export class CabineteComponent{
  cabineteList: any[] = [];
  httpService: HttpService;

  constructor(httpService: HttpService){
    this.httpService = httpService;
  }

    displayedColumns: string[] = [
    'id_cabinet',
    'nr_cabinet',
    'is_active'
    ];

ngOnInit(): void {
this.httpService.getAllCabinete().subscribe((data) => {
  this.cabineteList = data;
  console.log(this.cabineteList);
}), (err: any) => {
console.error(err);
};
  
}
 
}
