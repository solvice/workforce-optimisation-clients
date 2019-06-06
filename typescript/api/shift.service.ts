/**
 * Workforce Optimisation API
 * Solver engine for solving workforce optimisation problems
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@solvice.io
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *//* tslint:disable:no-unused-variable member-ordering */

import { Inject, Injectable, Optional }                      from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams,
         HttpResponse, HttpEvent }                           from '@angular/common/http';
import { CustomHttpUrlEncodingCodec }                        from '../encoder';

import { Observable }                                        from 'rxjs/Observable';

import { InlineResponse400 } from '../model/inlineResponse400';
import { ShiftRequest } from '../model/shiftRequest';
import { ShiftSolution } from '../model/shiftSolution';
import { StatusJob } from '../model/statusJob';

import { BASE_PATH, COLLECTION_FORMATS }                     from '../variables';
import { Configuration }                                     from '../configuration';


@Injectable()
export class ShiftService {

    protected basePath = 'https://api-dev.solvice.io';
    public defaultHeaders = new HttpHeaders();
    public configuration = new Configuration();

    constructor(protected httpClient: HttpClient, @Optional()@Inject(BASE_PATH) basePath: string, @Optional() configuration: Configuration) {
        if (basePath) {
            this.basePath = basePath;
        }
        if (configuration) {
            this.configuration = configuration;
            this.basePath = basePath || configuration.basePath || this.basePath;
        }
    }

    /**
     * @param consumes string[] mime-types
     * @return true: consumes contains 'multipart/form-data', false: otherwise
     */
    private canConsumeForm(consumes: string[]): boolean {
        const form = 'multipart/form-data';
        for (const consume of consumes) {
            if (form === consume) {
                return true;
            }
        }
        return false;
    }


    /**
     * Get a solution
     * 
     * @param jobId Job ID
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public getSolution(jobId: number, observe?: 'body', reportProgress?: boolean): Observable<ShiftSolution>;
    public getSolution(jobId: number, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<ShiftSolution>>;
    public getSolution(jobId: number, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<ShiftSolution>>;
    public getSolution(jobId: number, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (jobId === null || jobId === undefined) {
            throw new Error('Required parameter jobId was null or undefined when calling getSolution.');
        }

        let headers = this.defaultHeaders;

        // authentication (basicAuth) required
        if (this.configuration.username || this.configuration.password) {
            headers = headers.set('Authorization', 'Basic ' + btoa(this.configuration.username + ':' + this.configuration.password));
        }

        // authentication (bearerAuth) required
        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            'application/json'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
        ];

        return this.httpClient.get<ShiftSolution>(`${this.basePath}/jobs/${encodeURIComponent(String(jobId))}/solution`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Get a status
     * 
     * @param jobId Job ID
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public getStatus(jobId: string, observe?: 'body', reportProgress?: boolean): Observable<StatusJob>;
    public getStatus(jobId: string, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<StatusJob>>;
    public getStatus(jobId: string, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<StatusJob>>;
    public getStatus(jobId: string, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (jobId === null || jobId === undefined) {
            throw new Error('Required parameter jobId was null or undefined when calling getStatus.');
        }

        let headers = this.defaultHeaders;

        // authentication (basicAuth) required
        if (this.configuration.username || this.configuration.password) {
            headers = headers.set('Authorization', 'Basic ' + btoa(this.configuration.username + ':' + this.configuration.password));
        }

        // authentication (bearerAuth) required
        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            'application/json'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
        ];

        return this.httpClient.get<StatusJob>(`${this.basePath}/jobs/${encodeURIComponent(String(jobId))}/status`,
            {
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

    /**
     * Solve SHIFT problem
     * Endpoint for solving shift optimisation problem. 
     * @param body Optional description in *Markdown*
     * @param seconds The number of seconds you give the solver to optimise the SHIFT problem. By default, the solver decides.
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public solveShiftProblem(body: ShiftRequest, seconds?: number, observe?: 'body', reportProgress?: boolean): Observable<StatusJob>;
    public solveShiftProblem(body: ShiftRequest, seconds?: number, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<StatusJob>>;
    public solveShiftProblem(body: ShiftRequest, seconds?: number, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<StatusJob>>;
    public solveShiftProblem(body: ShiftRequest, seconds?: number, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {

        if (body === null || body === undefined) {
            throw new Error('Required parameter body was null or undefined when calling solveShiftProblem.');
        }


        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (seconds !== undefined && seconds !== null) {
            queryParameters = queryParameters.set('seconds', <any>seconds);
        }

        let headers = this.defaultHeaders;

        // authentication (basicAuth) required
        if (this.configuration.username || this.configuration.password) {
            headers = headers.set('Authorization', 'Basic ' + btoa(this.configuration.username + ':' + this.configuration.password));
        }

        // authentication (bearerAuth) required
        // to determine the Accept header
        let httpHeaderAccepts: string[] = [
            'application/json'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected != undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
            'application/json'
        ];
        const httpContentTypeSelected: string | undefined = this.configuration.selectHeaderContentType(consumes);
        if (httpContentTypeSelected != undefined) {
            headers = headers.set('Content-Type', httpContentTypeSelected);
        }

        return this.httpClient.post<StatusJob>(`${this.basePath}/solve`,
            body,
            {
                params: queryParameters,
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

}
