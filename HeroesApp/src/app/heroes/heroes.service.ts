import { Injectable } from '@angular/core';
import { HttpService, GraphQLRequestOptions } from '../services/http.service';
import { Observable } from 'rxjs';
import { switchMap, tap, map } from 'rxjs/operators';

export class SecretIdentity {
    firstName: string;
    lastName: string;
}

export class Hero {
    Id: number;
    name: string;
    description: string;
    secretIdentity: SecretIdentity;
}

@Injectable()
export class HeroesService {
    constructor(private httpService: HttpService) {
    }

    getHeroes(): Observable<Array<Hero>> {
        return this.httpService.makeGraphQLGetRequest(<GraphQLRequestOptions>{
            query: `{
                heroes {
                    id,
                    name,
                    description,
                    secretIdentity{
                        firstName,
                        lastName
                    }
                }
            }`
        }).pipe(
            map(g => <Array<Hero>>g.heroes));
    }

    getHero(id:number): Observable<Hero> {
        return this.httpService.makeGraphQLGetRequest(<GraphQLRequestOptions>{
            query: `{
                hero(id:${id}) {
                    id,
                    name,
                    description,
                    secretIdentity{
                        firstName,
                        lastName
                    }
                }
            }`
        }).pipe(
            map(g => <Hero>g.hero));
    }
}
