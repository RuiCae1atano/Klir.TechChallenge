import { Component } from '@angular/core';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent {
  products = [
    {
      id: 1,
      name: 'Product 1',
      price: '$20.00',
      promotion: 'Promotion Name',
      image: 'https://i.pinimg.com/originals/af/dd/f1/afddf1384f33f24153e6a88f6498736e.png',
    },
    {
      id: 2,
      name: 'Product 2',
      price: '$30.00',
      promotion: 'Promotion Name',
      image: 'https://i.pinimg.com/originals/af/dd/f1/afddf1384f33f24153e6a88f6498736e.png',
    },
    {
      id: 3,
      name: 'Product 3',
      price: '$25.00',
      promotion: 'Promotion Name',
      image: 'https://i.pinimg.com/originals/af/dd/f1/afddf1384f33f24153e6a88f6498736e.png',
    },
    {
      id: 4,
      name: 'Product 4',
      price: '$35.00',
      promotion: 'Promotion Name',
      image: 'https://i.pinimg.com/originals/af/dd/f1/afddf1384f33f24153e6a88f6498736e.png',
    },
  ];

  addProduct() {
    // Add a new product to the end of the array
    this.products.push({
      id: this.products.length + 1,
      name: 'New Product',
      price: '$0.00',
      promotion: '',
      image: '',
    });
  }

  deleteProduct(index: number) {
    // Remove the product at the given index
    this.products.splice(index, 1);
  }

  addToCart(productId: number) {
    // Add the product with the given id to the shopping cart
    console.log(`Product ${productId} added to cart`);
  }
}
