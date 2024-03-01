import { Component, OnInit, inject } from '@angular/core';
import { HttpService } from '../../login/service/http.service';
import { DxDataGridModule } from 'devextreme-angular';
import { Router } from '@angular/router';

@Component({
  selector: 'app-profesori',
  templateUrl: './profesori.component.html',
  styleUrls: ['./profesori.component.css']
})
export class ProfesoriComponent implements OnInit {
  router=inject(Router )
  profesoriList: any[] = [];
  httpService: HttpService;

  constructor(httpService: HttpService) {
    this.httpService = httpService;
  }
  displayedColumns: string[] = [
    'id_prof',
    'nume',
    'prenume',
    'patronimic',
    'data_activarii', 
    'end_data_activarii', 
    'is_active', 
    'functia',
    'action'
  ];
    
  ngOnInit() {
    this.httpService.getAllProfesori().subscribe((data) => {
        this.profesoriList = data;
        console.log(this.profesoriList);
  }), (err: any) => {
      console.error(err);
  };
}

edit(id_prof:number){
  console.log(id_prof)
  this.router.navigateByUrl("/profesori" + id_prof)
}

}
