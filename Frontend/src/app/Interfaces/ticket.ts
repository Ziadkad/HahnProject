import {Status} from "../Enums/status";

export interface Ticket {
  ticketId : number,
  description : string,
  status : Status,
  date : Date
}
