interface ICartItem {
    id: number;
    name: string;
    price: number;
    quantity: number;
    promotionId?: number;
    promotionName: string;
    totalPrice?: number
  }