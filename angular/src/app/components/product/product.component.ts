import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { IProduct } from 'src/app/models/product';
import { ProductService } from 'src/app/service/product/product.service';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit, OnDestroy {
  sub!: Subscription;
  products: IProduct[] = [];
  shoppingCart = [];
  errorMessage: string = '';

  constructor(private productService: ProductService) { }

  addProduct() {
    // Add a new product to the end of the array
    // if (this.shoppingCart
    // const existingItem = this.items.find(item => item.product.id === product.id);


    // this.shoppingCart.push({
    //   id: this.products.length + 1,
    //   name: this.products[length].name,
    //   price: this.products[length].price,
    //   promotion: this.products[length].promotion
    // });
  }

  deleteProduct(index: number) {
    // Remove the product at the given index
    // this.products.splice(index, 1);
  }

  addToCart(productId: number) {
    // Add the product with the given id to the shopping cart
    console.log(`Product ${productId} added to cart`);
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
