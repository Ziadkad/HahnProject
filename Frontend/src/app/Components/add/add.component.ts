import { Component } from '@angular/core';
import {FormBuilder, FormGroup, Validators} from "@angular/forms";
import {TicketService} from "../../Services/TicketService/ticket.service";
import {ActivatedRoute, Router} from "@angular/router";
import {Status} from "../../Enums/status";
import {ToastrService} from "ngx-toastr";

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrl: './add.component.css'
})
export class AddComponent {
  ticketForm! : FormGroup;
  add : boolean = true;
  id! : number;
  submitted: boolean = false;
  statusOptions: { key: string, value: number }[] = Object.keys(Status)
    .filter(key => isNaN(Number(key)))
    .map(key => ({ key, value: Status[key as keyof typeof Status] }));

  hasError: boolean = false;
  errorMessage! : string;



  constructor( private route : ActivatedRoute,
               private formBuilder: FormBuilder,
               private ticketService: TicketService,
               private router:Router,
               private toastr: ToastrService) {
  }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      if (params['id']) {
        this.add = false;
        this.id = params['id'];
        this.ticketService.getTicket(params['id']).subscribe(data => {
          this.patchForm(data.ticketId,data.description,data.status,new Date(data.date));
        },
        (error) => {
          console.error("Error getting the Ticket" + error)
          this.hasError = true;
          this.errorMessage = error.error;
        }
        )
      }
    })

    this.ticketForm = this.formBuilder.group({
      ticketId : 0,
      description : ['',  {
        validators: [Validators.required, Validators.minLength(10)],
      }],
      status : [Status.Open,Validators.required],
      date : [Date,Validators.required],
    })
  }


  patchForm(id:number, description : string, status : Status, date : Date){
    this.ticketForm.patchValue({
      ticketId : id,
      description:  description,
      status : status,
      date : date.toISOString().substring(0, 10),
    });
  }

  onSubmitTicketForm(){
    this.submitted = true;
    console.log(this.ticketForm.value);
    if(this.ticketForm.valid) {
      if (this.add) {
        this.Createticket();

      } else {
        this.UpdateTicket();
      }
    }
  }

  Createticket():void{
    this.ticketService.createTicket(this.ticketForm.value).subscribe(()=>{
      this.toastr.success("Your ticket was Added Successfully","Success",{
        timeOut: 2000,
      });
      setTimeout(() => {
        this.submitted = false;
        this.router.navigate(['']);
      }, 1000);
    },
    (error) => {
      this.toastr.error("Failed to add the ticket. Please try again.", "Error", {
        timeOut: 4000,
      });
      console.error("Error adding ticket:", error);
    })
  }

  UpdateTicket():void{
    this.ticketService.updateTicket(this.id,this.ticketForm.value).subscribe(()=>{
      this.toastr.success("Your ticket was Updated Successfully","Success",{
        timeOut: 2000,
      });
      setTimeout(() => {
        this.submitted = false;
        this.router.navigate(['']);
      }, 1000);
      },
      (error) => {
        this.toastr.error("Failed to update the ticket. Please try again.", "Error", {
          timeOut: 4000,
        });
        console.error("Error updating ticket:", error);
      })
  }



  protected readonly Status = Status;
}
