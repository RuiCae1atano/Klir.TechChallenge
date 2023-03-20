import { Injectable } from '@angular/core';
import { IPromotion } from 'src/app/models/promotion';
import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Observable, throwError } from "rxjs";
import { catchError, tap } from "rxjs/operators";
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PromotionService {

    private apiUrl =  environment.apiUrl;
    constructor(private http: HttpClient) { }

    createPromotion(promotion:IPromotion): Observable<IPromotion>{
        const httpOtions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
        };
        return this.http.post<IPromotion>(this.apiUrl + '/CreatePromotion', promotion, httpOtions);
    }
}
