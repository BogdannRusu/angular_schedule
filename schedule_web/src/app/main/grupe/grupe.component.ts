import { Component } from '@angular/core';
import { HttpService } from '../../login/service/http.service';

@Component({
  selector: 'app-grupe',
  templateUrl: './grupe.component.html',
  styleUrl: './grupe.component.css'
})
export class GrupeComponent {
  grupeList: any[] = [];
  httpService: HttpService;

  constructor(httpService: HttpService){
    this.httpService = httpService;
  }

    displayedColumns: string[] = [
    'id_grupa',
    'nume_grupa',
    'is_active',
    'anul',
    'id_link'
    ];

ngOnInit(): void {
this.httpService.getAllGrupe().subscribe((data) => {
  this.grupeList = data;
  console.log(this.grupeList);
}), (err: any) => {
console.error(err);
};
  
}
}
