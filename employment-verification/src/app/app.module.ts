import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { provideHttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EmploymentVerificationFormComponent } from './employment-verification-form/employment-verification-form.component';

@NgModule({
  declarations: [
    AppComponent,
    EmploymentVerificationFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
   ],
  providers: [provideHttpClient(),],
  bootstrap: [AppComponent], 
  })
export class AppModule { }


