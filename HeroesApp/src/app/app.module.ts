import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './header/header.component';
import { RecentsComponent } from './recents/recents.component';
import { HeroesComponent } from './heroes/heroes.component';
import { MoviesComponent } from './movies/movies.component';
import { AbilitiesComponent } from './abilities/abilities.component';
import { WeaponsComponent } from './weapons/weapons.component';
import { TeamsComponent } from './teams/teams.component';
import { RecentsService } from './recents/recents.service';
import { Initializer } from './app.module.initializer';
import { ConfigService } from './services/config.service';
import { HttpService } from './services/http.service';
import { HttpClient, HttpHandler, HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { HeroesService } from './heroes/heroes.service';
import { ContentTypeInterceptor } from './interceptors/contenttype.interceptor';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    RecentsComponent,
    HeroesComponent,
    MoviesComponent,
    AbilitiesComponent,
    WeaponsComponent,
    TeamsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [
    HttpClient,
    HttpService,
    ConfigService,
    RecentsService,
    HeroesService,
    {
      provide: APP_INITIALIZER,
      useFactory: Initializer,
      multi: true,
      deps: [ConfigService]
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: ContentTypeInterceptor,
      multi: true,
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
