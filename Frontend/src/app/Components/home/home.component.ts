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

  //filters
  selectedStatus?: Status;
  filterDescription?: string;
  filterStartDate?: string;
  filterEndDate?: string;
  statusOptions: { key: string, value: number }[] = Object.keys(Status)
    .filter(key => isNaN(Number(key)))
    .map(key => ({ key, value: Status[key as keyof typeof Status] }));

  constructor(private ticketService:TicketService) {
  }

  ngOnInit(){
    console.log("test");
    this.getTickets(this.activePage,this.pageSize);
  }

  getTickets(page: number, pageSize: number, status?: Status, description?: string, startDate?: string, endDate?: string) : void {

    console.log("get func  "+status + description);
    this.ticketService.getAllTickets(page, pageSize, status, description, startDate, endDate).subscribe(data=>{
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

  applyFilters(): void {
    this.activePage = 1;
    console.log(this.selectedStatus);
    this.getTickets(this.activePage, this.pageSize, this.selectedStatus, this.filterDescription, this.filterStartDate, this.filterEndDate);
  }

  changePage(page: number): void {
    if (page > 0 && page <= this.pageCount) {
      this.activePage = page;
      this.getTickets(this.activePage, this.pageSize, this.selectedStatus, this.filterDescription, this.filterStartDate, this.filterEndDate);
    }
  }


  isFirstPage(): boolean {
    return this.activePage === 1;
  }

  isLastPage(): boolean {
    return this.activePage === this.pageCount;
  }
}
