import { Component } from '@angular/core';
import { RecentsService } from './recents/recents.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'HeroesApp';
  recentsService: RecentsService;

  constructor(recentsService: RecentsService) {
    this.recentsService = recentsService;
  }
}
