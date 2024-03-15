import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AssessmentListComponent } from './Components/assessment-list/assessment-list.component';
import { AddAssessmentComponent } from './Components/add-assessment/add-assessment.component';


@NgModule({
  declarations: [
    AppComponent,
    AssessmentListComponent,
    AddAssessmentComponent
    ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
