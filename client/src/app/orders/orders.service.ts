import { HttpClient } from '@angular/common/http';
import { environment } from './../../environments/environment';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class OrdersService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getOrderForuser() {
    return this.http.get(this.baseUrl + 'order');
  }

  getOrderDetailed(id: number) {
    return this.http.get(this.baseUrl + 'order/' + id);
  }
}
