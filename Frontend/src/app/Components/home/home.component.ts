import { Component } from '@angular/core';
import {TicketService} from "../../Services/TicketService/ticket.service";
import {Status} from "../../Enums/status";
import {Observable} from "rxjs";
import {Ticket} from "../../Interfaces/ticket";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  tickets! : Ticket[];
  pageCount! : number;
  readonly pageSize : number = 10;
  constructor(private ticketService:TicketService) {
  }

  ngOnInit(){
    console.log("test");
    this.getTickets(1,this.pageSize);
  }

  getTickets(page: number, pageSize: number, status?: Status, description?: string, startDate?: Date, endDate?: Date) : void {
    this.ticketService.getAllTickets(page, pageSize, status, description, startDate, endDate).subscribe(data=>{
      console.log(data);
      this.tickets = data.tickets;
      this.pageCount = data.pagesCount;
    })
  }
}
