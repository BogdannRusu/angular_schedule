import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { LoginComponent } from './login/login.component';
import { AppComponent } from './app.component';
import { MainComponent } from './main/main.component';
import { OrarComponent } from './orar/orar.component';
import { ScheduleComponent } from './schedule/schedule.component';
import { ClockComponent } from './analog-clock/analog-clock.component';
import { HeaderComponent } from './header/header.component';
import { FlipperComponent } from './analog-clock/flipper/flipper.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    MainComponent,
    OrarComponent,
    ScheduleComponent,
    ClockComponent,
    HeaderComponent,
    FlipperComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
