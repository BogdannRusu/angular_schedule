import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { MainComponent } from './main/main.component';
import { OrarComponent } from './orar/orar.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { ProfesoriComponent } from './main/profesori/profesori.component';
import { CabineteComponent } from './main/cabinete/cabinete.component';
import { GrupeComponent } from './main/grupe/grupe.component';

const routes : Routes = [
  //Login
  { path: 'login', component: LoginComponent },

  //Main
  { path: 'main', component: MainComponent },

   //Orar
  { path: 'orar', component: OrarComponent },

  //Schedule
{  path: 'program', component: ScheduleComponent },


//Profesori,Cabinete,Grupe
{  path: 'profesori', component: ProfesoriComponent },
{  path: 'cabinete', component: CabineteComponent },
{  path: 'grupe', component: GrupeComponent },



  //Default path
{  path: '', component: LoginComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
