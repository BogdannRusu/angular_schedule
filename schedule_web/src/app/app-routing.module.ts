import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { MainComponent } from './main/main.component';
import { OrarComponent } from './orar/orar.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { ClockComponent } from './analog-clock/analog-clock.component';
import { HeaderComponent } from './header/header.component';

const routes : Routes = [
  //Login
  { path: 'login', component: LoginComponent },

  //Main
  { path: 'main', component: MainComponent },

   //Orar
  { path: 'orar', component: OrarComponent },

   //Ceas
  { path: 'clock', component: ClockComponent },

  //Schedule
{  path: 'program', component: ScheduleComponent },

  //Header
{  path: 'header', component: HeaderComponent },

  //Default path
{  path: '', component: LoginComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
