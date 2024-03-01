import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { MainComponent } from './main/main.component';
import { ProfesoriComponent } from './main/profesori/profesori.component';
import { CabineteComponent } from './main/cabinete/cabinete.component';
import { ContainerComponent } from './main/containerProfesori/container.component';
import { ContainerGrupeComponent } from './main/container-grupe/container-grupe.component';
import { ContainerCabineteComponent } from './main/container-cabinete/container-cabinete.component';
import { Error404Component } from './error404/error404.component';

const routes : Routes = [
  //Login
  { path: 'login', component: LoginComponent },
  { path: 'main', component: MainComponent },
  

//Profesori,Cabinete,Grupe
{  path: 'profesori', component: ContainerComponent },
{  path: 'profesori/:id', component: ProfesoriComponent },
{  path: 'cabinete', component: ContainerCabineteComponent },
{  path: 'grupe', component: ContainerGrupeComponent },
{  path: 'error', component: Error404Component },



  //Default path
{  path: '', component: LoginComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
