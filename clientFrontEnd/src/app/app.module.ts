import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ClientComponent } from './views/client/client.component';
import { AddUpdateComponent } from './views/client/add-update/add-update.component';
import { ListsComponent } from './views/client/lists/lists.component';
import { ReactiveFormsModule } from '@angular/forms';
import { ClientService } from './services/client.service';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import {MatRadioModule} from '@angular/material/radio';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
@NgModule({
  declarations: [
    AppComponent,
    ClientComponent,
    AddUpdateComponent,
    ListsComponent,
    
  ],
  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatRadioModule,
   
    BrowserAnimationsModule,
    ToastrModule.forRoot()
    
  ],
  providers: [ClientService],
  bootstrap: [AppComponent]
})
export class AppModule { }
