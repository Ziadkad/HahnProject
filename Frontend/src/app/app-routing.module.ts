import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {HomeComponent} from "./Components/home/home.component";
import {AddComponent} from "./Components/add/add.component";

const routes: Routes = [
  { path:'', component: HomeComponent},
  { path:'addTicket', component: AddComponent},
  { path:'updateTicket/:id', component: AddComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
