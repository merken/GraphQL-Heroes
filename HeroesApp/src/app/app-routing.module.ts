import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { HeroesComponent } from './heroes/heroes.component';
import { TeamsComponent } from './teams/teams.component';
import { WeaponsComponent } from './weapons/weapons.component';
import { AbilitiesComponent } from './abilities/abilities.component';
import { MoviesComponent } from './movies/movies.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'heroes', component: HeroesComponent },
  { path: 'movies', component: MoviesComponent },
  { path: 'abilities', component: AbilitiesComponent },
  { path: 'weapons', component: WeaponsComponent },
  { path: 'teams', component: TeamsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
