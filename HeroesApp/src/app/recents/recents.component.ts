import { Component, OnInit } from '@angular/core';
import { RecentsService } from './recents.service';
import { Observable } from 'rxjs';
import { RecentItem } from '../models/RecentItem';

@Component({
  selector: 'app-recents',
  templateUrl: './recents.component.html',
  styleUrls: ['./recents.component.css']
})
export class RecentsComponent implements OnInit {
  recents$: Observable<Array<RecentItem>>;

  constructor(recentsService: RecentsService) {
    this.recents$ =  recentsService.recents;
  }

  ngOnInit() {
  }

}
