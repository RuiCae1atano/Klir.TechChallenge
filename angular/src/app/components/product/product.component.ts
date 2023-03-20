import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { IProduct } from 'src/app/models/product';
import { ShoppingCart } from 'src/app/models/shopping-cart';
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
  shoppingCart : ShoppingCart;
  itemProduct: ICartItem;

  constructor(private productService: ProductService) { }

  removeProduct(index: number) {
    this.shoppingCart.removeItem(index);
    console.log(this.shoppingCart);
  }


  onClick(product:IProduct): void{
    this.addToCart(product);
    //change the buttons
    
  }

  addToCart(product:IProduct) {   
    this.itemProduct.id = product.id;
    this.itemProduct.name = product.name;
    this.itemProduct.price = product.price;
    this.itemProduct.promotionId = product.promotionId;
    this.itemProduct.promotionName = product.promotionName;

    this.shoppingCart.addItem(this.itemProduct);
    console.log(this.shoppingCart);
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
