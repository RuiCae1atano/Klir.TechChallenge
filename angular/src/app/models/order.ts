import { IOrderItem } from "./order-item";

export interface IOrder{
    id?: number,
    orderItems: Array<IOrderItem>
}