import { Injectable } from '@angular/core';
import {environment} from "../../../environments/environment";
import {HttpClient, HttpParams} from "@angular/common/http";
import {Observable} from "rxjs";
import {Ticket} from "../../Interfaces/ticket";
import {Status} from "../../Enums/status";
import {list} from "postcss";
import {ListTickets} from "../../Interfaces/list-tickets";

@Injectable({
  providedIn: 'root'
})
export class TicketService {
  private apiUrl: string;
  constructor(private http:HttpClient) {
    this.apiUrl = `${environment.apiUrl}/Ticket`
  }

  getAllTickets(page: number, pageSize: number, status?: Status, description?: string, startDate?: Date, endDate?: Date): Observable<ListTickets> {
    let params = new HttpParams()
      .set('page', page)
      .set('pageSize', pageSize);
    if (status) {
      params = params.set('status', status);
    }
    if (description) {
      params = params.set('description', description);
    }
    if (startDate) {
      params = params.set('startDate', startDate.toISOString());
    }
    if (endDate) {
      params = params.set('endDate', endDate.toISOString());
    }
    return this.http.get<ListTickets>(this.apiUrl, { params });
  }

  //Get a ticket by ID
  getTicket(id: number): Observable<Ticket> {
    return this.http.get<Ticket>(`${this.apiUrl}/${id}`);
  }

  // Create a new ticket
  createTicket(ticket: Ticket): Observable<Ticket> {
    return this.http.post<Ticket>(this.apiUrl, ticket);
  }

  // Update an existing ticket by ID
  updateTicket(id: number, ticket: Ticket): Observable<Ticket> {
    return this.http.put<Ticket>(`${this.apiUrl}/${id}`, ticket);
  }

  // Delete a ticket by ID
  deleteTicket(id: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }

}
