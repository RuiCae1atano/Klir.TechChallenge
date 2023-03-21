import { TestBed } from "@angular/core/testing";
import { ShoppingCartService } from "./shopping-cart.service";

describe('ShoppingCartService', () => {
  let service: ShoppingCartService;

  beforeEach(() => {
    TestBed.configureTestingModule({providers : [ShoppingCartService]});
  });

  it('should not apply Buy 1 Get 1 Free promotion when item quantity is 1', () => {
    const item = {"Item": "Product E", "Quantity":1, "Price":10, "Total": 10, "Promotion Applied": 'Buy 1 Get 1 Free'};
    service.applyPromotions();
    expect(item.Total).toBe(10);
  });

  it('should apply Buy 1 Get 1 Free promotion once when item quantity is 2', () => {
    const item = {"Item": "Product E", "Quantity":2, "Price":10, "Total": 20, "Promotion Applied": 'Buy 1 Get 1 Free'};
    service.applyPromotions();
    expect(item.Total).toBe(10);
  });

  it('should apply Buy 1 Get 1 Free promotion once when item quantity is 3', () => {
    const item = {"Item": "Product E", "Quantity":3, "Price":10, "Total": 30, "Promotion Applied": 'Buy 1 Get 1 Free'};
    service.applyPromotions();
    expect(item.Total).toBe(20);
  });

  it('should apply Buy 1 Get 1 Free promotion twice when item quantity is 4', () => {
    const item = {"Item": "Product E", "Quantity":4, "Price":10, "Total": 40, "Promotion Applied": 'Buy 1 Get 1 Free'};
    service.applyPromotions();
    expect(item.Total).toBe(20);
  });

  it('should apply 3 for 10 Euro promotion once when item quantity is 3', () => {
    const item = {"Item": "Product E", "Quantity":3, "Price":4, "Total": 12, "Promotion Applied": '3 for 10 Euro'};
    service.applyPromotions();
    expect(item.Total).toBe(10);
  });

  it('should apply 3 for 10 Euro promotion once when item quantity is 4', () => {
    const item = {"Item": "Product E", "Quantity":4, "Price":4, "Total": 16, "Promotion Applied": '3 for 10 Euro'};
    service.applyPromotions();
    expect(item.Total).toBe(10);
  });

  it('should apply 3 for 10 Euro promotion twice when item quantity is 6', () => {
    const item = {"Item": "Product E", "Quantity":6, "Price":4, "Total": 24, "Promotion Applied": '3 for 10 Euro'};
    service.applyPromotions();
    expect(item.Total).toBe(20);
  });

  it('should not apply 3 for 10 Euro promotion when item quantity is less than 3', () => {
    const item = {"Item": "Product E", "Quantity":2, "Price":4, "Total": 8, "Promotion Applied": '3 for 10 Euro'};
    service.applyPromotions();
    expect(item.Total).toBe(8);
  });

  it('should apply 3 for 10 Euro promotion correctly', () => {
    const products = [      {Item: 'Product A', Quantity: 2, Price: 5, Total: 10, PromotionApplied: ''},      {Item: 'Product B', Quantity: 3, Price: 3, Total: 9, PromotionApplied: '3 for 10 Euro'},      {Item: 'Product C', Quantity: 4, Price: 2, Total: 8, PromotionApplied: '3 for 10 Euro'},      {Item: 'Product D', Quantity: 6, Price: 1.5, Total: 9, PromotionApplied: '3 for 10 Euro'}    ];
    service.applyPromotions();
    expect(products[1].Total).toEqual(10);
    expect(products[2].Total).toEqual(10);
    expect(products[3].Total).toEqual(10.5);
  });

  it('should not apply 3 for 10 Euro promotion when quantity is less than 3', () => {
    const products = [      {Item: 'Product A', Quantity: 1, Price: 5, Total: 5, PromotionApplied: ''},      {Item: 'Product B', Quantity: 2, Price: 3, Total: 6, PromotionApplied: '3 for 10 Euro'}    ];
    service.applyPromotions();
    expect(products[1].Total).toEqual(6);
  });
});