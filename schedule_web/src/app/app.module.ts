import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';
import { MatTableModule } from '@angular/material/table';

import { AppRoutingModule } from './app-routing.module';
import { LoginComponent } from './login/login.component';
import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { OrarComponent } from './orar/orar.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { ProfesoriComponent } from './main/profesori/profesori.component';
import { GrupeComponent } from './main/grupe/grupe.component';
import { CabineteComponent } from './main/cabinete/cabinete.component';
import { provideHttpClient } from '@angular/common/http';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    OrarComponent,
    ScheduleComponent,
    ProfesoriComponent,
    GrupeComponent,
    CabineteComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    LoginComponent,
    MatTableModule
    
  ],
  providers: [
    provideClientHydration(),
    provideHttpClient(),
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
