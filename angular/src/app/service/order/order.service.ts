import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Observable, throwError } from "rxjs";
import { catchError, tap } from "rxjs/operators";
import { environment } from 'src/environments/environment';
import { IOrder } from 'src/app/models/order';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

private apiUrl =  environment.apiUrl;
constructor(private http: HttpClient) { }

createPromotion(promotion:IOrder): Observable<IOrder>{
    const httpOtions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
    };
    return this.http.post<IOrder>(this.apiUrl + '/CreateOrder', promotion, httpOtions);
}

}
