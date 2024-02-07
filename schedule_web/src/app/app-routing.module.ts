import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { MainComponent } from './main/main.component';
import { OrarComponent } from './orar/orar.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { ClockComponent } from './analog-clock/analog-clock.component';

const routes : Routes = [{
  //Login
  path: 'login',
  component: LoginComponent
},

{
  //Main
  path: 'main',
  component: MainComponent
},

{
  //Orar
  path: 'orar',
  component: OrarComponent

},

//Ceas
{
   path: 'clock',
   component: ClockComponent
},

{
  //Schedule
  path: 'program',
  component: ScheduleComponent
},

{
  path: '**',  // Default route to redirect to login page if no other matches found
  redirectTo: 'login', pathMatch: 'full'
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
