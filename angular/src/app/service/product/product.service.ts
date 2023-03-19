import { Injectable } from '@angular/core';
import {IProduct} from '../../models/product'

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor() { }


  //createProducts
  
  
  //changePromotionfromProducts



  //api to getProduct
  getProducts(): IProduct[]{
    return[
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
  }
}
