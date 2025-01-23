import { importProvidersFrom, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AboutUsComponent } from './compoents/core/about-us/about-us.component';
import { HomeComponent } from './components/home/home.component';
import { NavBarComponent } from './components/core/nav-bar/nav-bar.component';
import { CarouselComponent, CarouselModule } from 'ngx-bootstrap/carousel';

@NgModule({
  declarations: [
    AppComponent,
    AboutUsComponent,
    HomeComponent,
    NavBarComponent,
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CarouselModule
  ],
  providers: [
    importProvidersFrom(CarouselModule.forRoot())
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
