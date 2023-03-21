import { Component, OnDestroy, OnInit } from '@angular/core';
import { ShoppingCartService } from 'src/app/service/cart/shopping-cart.service';
import { OrderService } from 'src/app/service/order/order.service';

@Component({
  selector: 'app-shopping-cart',
  templateUrl: './shopping-cart.component.html',
  styleUrls: ['./shopping-cart.component.css']
})
export class ShoppingCartComponent implements OnInit {

  cartItems: ICartItem[]=[]; 

  constructor(private shoppingCartService: ShoppingCartService, private orderService: OrderService) {
    this.shoppingCartService.itemsCount();
  }

  getTotalPrice(){
    const total = this.cartItems.reduce(
      (acc, item) => acc + item.price * item.quantity,
      0
    );

    this.shoppingCartService.getTotal();
  }

  deleteItem(){};

  removeQuantity(i){};

  checkout(){
    this.orderService.createOrder(this.cartItems);
  }

  ngOnInit(): void {
    this.cartItems =  this.shoppingCartService.getCart();  
    this.getTotalPrice();
  }

}
