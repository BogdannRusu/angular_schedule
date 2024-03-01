import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';
import { MatTableModule } from '@angular/material/table';

import { AppRoutingModule } from './app-routing.module';
import { LoginComponent } from './login/login.component';
import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { ProfesoriComponent } from './main/profesori/profesori.component';
import { GrupeComponent } from './main/grupe/grupe.component';
import { CabineteComponent } from './main/cabinete/cabinete.component';
import { provideHttpClient } from '@angular/common/http';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { ContainerComponent } from './main/containerProfesori/container.component';
import { ContainerGrupeComponent } from './main/container-grupe/container-grupe.component';
import { ContainerCabineteComponent } from './main/container-cabinete/container-cabinete.component';
import { Error404Component } from './error404/error404.component';

@NgModule({
  declarations: [
    AppComponent,
    MainComponent,
    ProfesoriComponent,
    GrupeComponent,
    CabineteComponent,
    ContainerComponent,
    ContainerGrupeComponent,
    ContainerCabineteComponent,
    Error404Component,
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
