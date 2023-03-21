import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class ShoppingCartService {
    private items: ICartItem[] = [];
  
    getCart(): ICartItem[]{
      return this.items;
    }

    addItem(item: ICartItem): void {
      const existingItem = this.items.find((i) => i.id === item.id);
      if (existingItem) {
        existingItem.quantity ++;
      } else {
        item.quantity = 1;
        this.items.push(item);
      }
    }
  
    removeItem(itemId: number): void {
      this.items = this.items.filter((i) => i.id !== itemId);
    }

    itemsCount(){
      return this.items.length;
    }
  
    updateItemQuantity(itemId: number, newQuantity: number): void {
      const itemToUpdate = this.items.find((i) => i.id === itemId);
      if (itemToUpdate) {
        itemToUpdate.quantity = newQuantity;
      }
    }

    getTotal(){
      const total = this.items.reduce(
        (acc, item) => acc + item.price * item.quantity,
        0
      );
    }

    applyPromotions(){
      this.items.forEach(item => {
        if (item['Promotion Applied'] === 'Buy 1 Get 1 Free') {
          if (item.quantity >= 2) {
            item.totalPrice = Math.floor(item.quantity / 2) * item.price + (item.quantity % 2) * item.price;
          }
        } else if (item['Promotion Applied'] === '3 for 10 Euro') {
          if (item.quantity >= 3) {
            item.totalPrice = Math.floor(item.quantity / 3) * 10 + (item.quantity % 3) * item.price;
          }
        }
      });  
    }
  
  }