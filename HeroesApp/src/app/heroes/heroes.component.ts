import { Component, OnInit, OnDestroy } from '@angular/core';
import { HeroesService, Hero } from './heroes.service';
import { Observable, Subscription } from 'rxjs';

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit, OnDestroy {
  heroes: Array<Hero> = [];
  private heroesSubscription: Subscription;

  constructor(private heroesService: HeroesService) {
  }

  ngOnInit() {
    this.heroesSubscription = this.heroesService
      .getHeroes()
      .subscribe(heroes =>
        this.heroes = [...heroes]);
  }

  ngOnDestroy(): void {
    if (this.heroesSubscription) {
      this.heroesSubscription.unsubscribe();
    }
  }
}
