import { NgModule } from '@angular/core';
import { BrowserModule, provideClientHydration } from '@angular/platform-browser';

import { AppComponent } from './app-components/app.component';
import { LoginComponent } from './login/login.component';
import { TableSchedulerComponent } from './table-scheduler/table-scheduler.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    TableSchedulerComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [
    provideClientHydration()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
