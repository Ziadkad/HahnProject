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
  activePage : number = 1;
  constructor(private ticketService:TicketService) {
  }

  ngOnInit(){
    console.log("test");
    this.getTickets(this.activePage,this.pageSize);
  }

  getTickets(page: number, pageSize: number, status?: Status, description?: string, startDate?: Date, endDate?: Date) : void {
    this.ticketService.getAllTickets(page, pageSize, status, description, startDate, endDate).subscribe(data=>{
      console.log(data);
      this.tickets = data.tickets;
      this.pageCount = data.pagesCount;
    })
  }

  deleteTicket(id:number) : void{
    const confirmed : boolean = confirm('Are you sure you want to delete this ticket?');
    if (confirmed) {
      this.ticketService.deleteTicket(id).subscribe(() => {
        this.getTickets(this.activePage, this.pageSize);
      });
    }
  }

  getTicketStatusText(status: Status): string {
    return Status[status];
  }

  changePage(page: number): void {
    if (page > 0 && page <= this.pageCount) {
      this.activePage = page;
      this.getTickets(this.activePage, this.pageSize);
    }
  }


  isFirstPage(): boolean {
    return this.activePage === 1;
  }

  isLastPage(): boolean {
    return this.activePage === this.pageCount;
  }
}
