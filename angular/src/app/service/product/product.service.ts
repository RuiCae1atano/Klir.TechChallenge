import { Injectable } from '@angular/core';
import {IProduct} from '../../models/product';
import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Observable, throwError } from "rxjs";
import { catchError, tap } from "rxjs/operators";
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  private productUrl =  environment.apiUrl;

  constructor(private http: HttpClient) { }

  getProducts(): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(this.productUrl + '/GetAllProducts')
    .pipe(tap(data => console.log('All', JSON.stringify(data))),
      catchError(this.handleError)
    );
  }

  createProduct(product:IProduct): Observable<IProduct>{
    const httpOtions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };
    return this.http.post<IProduct>(this.productUrl + '/CreateProduct', product, httpOtions);
  }

  updateProduct(product:IProduct): Observable<IProduct>{
    const httpOtions = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    };
    return this.http.post<IProduct>(this.productUrl + '/UpdateProduct', product, httpOtions);
  }  
  


  private handleError(err: HttpErrorResponse) {
    // in a real world app, we may send the server to some remote logging infrastructure
    // instead of just logging it to the console
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(() => errorMessage);
  }



}
