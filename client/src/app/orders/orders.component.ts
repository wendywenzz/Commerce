import { IOrder } from './../shared/models/order';
import { OrdersService } from './orders.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.scss'],
})
export class OrdersComponent implements OnInit {
  orders: IOrder[];
  constructor(private ordersService: OrdersService) {}

  ngOnInit(): void {
    this.getOrders();
  }

  getOrders() {
    this.ordersService.getOrderForuser().subscribe(
      (order: IOrder[]) => {
        this.orders = order;
      },
      (error) => {
        console.log(error);
      }
    );
  }
}
