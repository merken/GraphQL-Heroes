import { Component, OnInit, OnDestroy } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { HeroesService, Hero } from '../heroes/heroes.service';
import { Route, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-hero',
  templateUrl: './hero.component.html',
  styleUrls: ['./hero.component.css']
})
export class HeroComponent implements OnInit, OnDestroy {
  hero: Hero;
  private heroSubscription: Subscription;

  constructor(private heroesService: HeroesService, private route: ActivatedRoute) {
  }

  ngOnInit() {
    const id = parseInt(this.route.snapshot.paramMap.get('id'));
    this.heroSubscription = this.heroesService
      .getHero(id)
      .subscribe(hero =>
        this.hero = hero);
  }

  ngOnDestroy(): void {
    if (this.heroSubscription) {
      this.heroSubscription.unsubscribe();
    }
  }
}
