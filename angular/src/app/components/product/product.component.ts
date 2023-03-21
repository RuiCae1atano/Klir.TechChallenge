import { Component, Injectable, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { IProduct } from 'src/app/models/product';
import { ShoppingCartService } from 'src/app/service/cart/shopping-cart.service';
import { ProductService } from 'src/app/service/product/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})



export class ProductComponent implements OnInit, OnDestroy {
  sub!: Subscription;
  products: IProduct[] = [];
  errorMessage: string = '';
  itemProduct: ICartItem;
  

  constructor(private productService: ProductService, private shoppingCart: ShoppingCartService) { }

  removeProduct(index: number) {
    this.shoppingCart.removeItem(index);
  }


  onClick(product:IProduct): void{
    this.addToCart(product);
    //change the buttons 
  }

  addToCart(product:IProduct) {   
    var myItem = {} as ICartItem;
    myItem.id = product.id;
    myItem.name = product.name;
    myItem.price = product.price;
    myItem.promotionId = product.promotionId;
    myItem.promotionName = product.promotionName;


    this.shoppingCart.addItem(myItem);
  }

  ngOnInit(): void {
    this.sub = this.productService.getProducts().subscribe({
      next: products => {
        this.products = products;
      },
      error: err => this.errorMessage = err
    });
  }

  ngOnDestroy(): void {
    this.sub.unsubscribe();
  }

}
