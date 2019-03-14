import { Injectable } from '@angular/core';
import { RecentItem } from '../models/RecentItem';
import { Router, NavigationEnd } from '@angular/router';
import { Subject } from 'rxjs';
import { filter } from 'rxjs/operators';

@Injectable()
export class RecentsService {
    private recentsInternal: Array<RecentItem>;
    recents: Subject<Array<RecentItem>>;

    constructor(private router: Router) {
        this.recentsInternal = new Array<RecentItem>();
        this.recents = new Subject<Array<RecentItem>>();
        router.events
            .pipe(filter(e => e instanceof NavigationEnd))
            .subscribe((nagivationEnd: NavigationEnd) => {
                const link = nagivationEnd.url;
                const title = document.title;

                this.recentsInternal.push({
                    link,
                    title
                });

                while (this.recentsInternal.length > 10) {
                    this.recentsInternal.pop();
                }

                this.recents.next(this.recentsInternal);
            });
    }
}
