import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { Cliente } from 'src/app/Models/Cliente';
import { Ticket } from 'src/app/Models/Ticket';
import { ClientService } from 'src/app/services/client.service';
@Component({
  selector: 'app-lists',
  templateUrl: './lists.component.html',
  styleUrls: ['./lists.component.scss']
})
export class ListsComponent implements OnInit {
  sub:Subscription
  clients:Cliente[]=[]
  constructor(public clienteService:ClientService, 
    private toastrService:ToastrService,) { }

  ngOnInit(): void {
    this.clienteService.getItemsClients();
  }

  UpdateStatus(id) 
  {
    let ticket:Ticket={tikId:id, tickEstado:3}
    
    this.clienteService.updateItemStatus(ticket)
      .subscribe(data => {
        this.clienteService.getItemsClients();
        this.toastrService.success("Cliente antendido","Exito");
        
      },
        (err) => {
        })
  }

}
