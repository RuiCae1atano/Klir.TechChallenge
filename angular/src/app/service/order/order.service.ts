import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Observable, throwError } from "rxjs";
import { catchError, tap } from "rxjs/operators";
import { environment } from 'src/environments/environment';
import { IOrder } from 'src/app/models/order';
import { IOrderItem } from 'src/app/models/order-item';
import { ShoppingCartComponent } from 'src/app/components/shopping-cart/shopping-cart.component';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

private apiUrl =  environment.apiUrl + '/order';
constructor(private http: HttpClient) { }

createOrder(cartItems :ICartItem[]): Observable<IOrder>{
    let order : IOrder;
    let orderItems : IOrderItem[];

    cartItems.forEach(item => {
      let orderItem: IOrderItem;
      orderItem.product.id = item.id;
      orderItem.product.name = item.name 
      orderItem.product.price = item.price
      orderItem.product.promotionId =  item.promotionId
      orderItem.quantity = item.quantity;

      orderItems.push(orderItem);
    });


    
    order.orderItems = orderItems;
    const total = orderItems.reduce(
      (acc, item) => acc + item.product.price * item.quantity,
      0
    );
    order.total = total;
    const httpOtions = {
    headers: new HttpHeaders({
        'Content-Type': 'application/json'
    })
    };
    return this.http.post<IOrder>(this.apiUrl + '/CreateOrder', order, httpOtions);
}

}
