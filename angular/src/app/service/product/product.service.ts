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

  private productUrl =  environment.apiUrl + '/product';

  constructor(private http: HttpClient) { }

  getProducts(): Observable<IProduct[]> {
    return this.http.get<IProduct[]>(this.productUrl + '/GetAllProducts')
    .pipe(tap(),
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
    let errorMessage = '';
    if (err.error instanceof ErrorEvent) {
      errorMessage = `An error occurred: ${err.error.message}`;
    } else {
      errorMessage = `Server returned code: ${err.status}, error message is: ${err.message}`;
    }
    console.error(errorMessage);
    return throwError(() => errorMessage);
  }



}
