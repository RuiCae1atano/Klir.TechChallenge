import {IProduct} from './product'

export interface IOrderItem {
      product: IProduct;
      quantity: number;
      orderId: number;
    }