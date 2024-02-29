import { Component, OnInit } from '@angular/core';
import { HttpService } from '../../login/service/http.service';
import {MatTableModule} from '@angular/material/table';
import { DxDataGridModule } from 'devextreme-angular';

@Component({
  selector: 'app-profesori',
  templateUrl: './profesori.component.html',
  styleUrls: ['./profesori.component.css']
})
export class ProfesoriComponent implements OnInit {

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
    'functia'];
    
  ngOnInit() {
    this.httpService.getAllProfesori().subscribe((data) => {
        this.profesoriList = data;
        console.log(this.profesoriList);
  }), (err: any) => {
      console.error(err);
  };
}
}
