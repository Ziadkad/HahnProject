import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import {HttpClient, HttpClientModule} from "@angular/common/http";
import { HomeComponent } from './Components/home/home.component';
import { AddComponent } from './Components/add/add.component';
import { NavbarComponent } from './Components/navbar/navbar.component';
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";
import {ToastrModule} from "ngx-toastr";
import { ErrorMessageComponent } from './Components/error-message/error-message.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    AddComponent,
    NavbarComponent,
    ErrorMessageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
