import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ConfigService } from './config.service';
import { map, catchError } from 'rxjs/operators';
import { Observable } from 'rxjs';

export class GraphQLRequestOptions {
    query: string;
}

class GraphQLResponse {
    data: any;
}

@Injectable()
export class HttpService {
    constructor(
        private http: HttpClient,
        private configService: ConfigService
    ) { }

    public makeGraphQLGetRequest(options: GraphQLRequestOptions): Observable<any> {
        const payload = JSON.stringify({
            query: options.query.replace(/[\n\r]+/g, '').replace(/\s{2,10}/g, ' ')
        });

        const httpOptions = {
            body: payload
        };

        return this.http
            .request('POST', `${this.configService.config.apiHost}/api/graphql`, httpOptions)
            .pipe(
                map((resp: GraphQLResponse) => resp.data || []),
                catchError(errResp => Observable.throw(errResp.error)));
    }
}
