export class ShoppingCart {
    private items: ICartItem[] = [];
  
    addItem(item: ICartItem): void {
      const existingItem = this.items.find((i) => i.id === item.id);
      if (existingItem) {
        existingItem.quantity += item.quantity;
      } else {
        this.items.push(item);
      }
    }
  
    removeItem(itemId: number): void {
      this.items = this.items.filter((i) => i.id !== itemId);
    }
  
    updateItemQuantity(itemId: number, newQuantity: number): void {
      const itemToUpdate = this.items.find((i) => i.id === itemId);
      if (itemToUpdate) {
        itemToUpdate.quantity = newQuantity;
      }
    }
  }