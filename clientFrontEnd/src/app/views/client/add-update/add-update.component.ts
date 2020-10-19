import { ChangeDetectorRef, Component, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { Subscription } from 'rxjs';
import { Cliente } from 'src/app/Models/Cliente';
import { Ticket } from 'src/app/Models/Ticket';
import { ClientService } from 'src/app/services/client.service';

@Component({
  selector: 'app-add-update',
  templateUrl: './add-update.component.html',
  styleUrls: ['./add-update.component.scss']
})
export class AddUpdateComponent implements OnInit, OnDestroy {
  public itemForm: FormGroup;
  subColas:Subscription
  tipoColas:any[]=[]
  constructor(    private fb: FormBuilder,
    private clienteService:ClientService,
    private toastrService:ToastrService,
    private cd: ChangeDetectorRef,) { }
  ngOnDestroy(): void {
    if(this.subColas)this.subColas.unsubscribe()
  }

  ngOnInit(): void {
    this.buildItemForm() 
    this.getItemsTiposColas() ;
  }
  buildItemForm(item?:Cliente) 
  {
  
    this.itemForm = this.fb.group({
      cliId: [item?item.cliId : 0],
     cliNombre: [item?item.cliNombre :'', Validators.required],
     cliIdentificacion: [item?item.cliIdentificacion : '', Validators.required],
     ticket: this.fb.group({
      tikId: [item?item.ticket.tikId : 0],
      ticId: [item?item.ticket.ticId : 1, Validators.required],
      cliId: [item?item.ticket.cliId : ''],
      
    }),
    })
  }

  submit() 
  {
    
    
    this.clienteService.addItem(this.itemForm.value)
      .subscribe(data => {
        this.clienteService.getItemsClients();
        this.toastrService.success("Dato agregado","Exito");
        this.itemForm.reset()
      },
        (err) => {
        })
  }

  


  getItemsTiposColas() 
  {
    this.subColas = this.clienteService.getItemsTipoCola()
      .subscribe(data =>
        {
        this.tipoColas = data;
        this.cd.markForCheck();
      }) 
  }

}
