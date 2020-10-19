import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Cliente } from '../Models/Cliente';
import { environment } from '../../environments/environment';
import {  map } from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class ClientService {
clients:Cliente[];
  constructor(private http: HttpClient) { }
 

//funcion para obtener el tipo de Cliente
getItemsClients()
{
  debugger
 //Empresa[] guardamos los datos que arroja la api
 return this.http.get<Cliente[]>(`${environment.urlService}/Cliente`).toPromise()
 .then(data=>{
   this.clients=data as Cliente[]
 });
}

getItemsTipoCola():Observable<any> 
{
 //Empresa[] guardamos los datos que arroja la api
 return this.http.get<Cliente[]>(`${environment.urlService}/TipoColas/`);
}
//funcion para añidar mas 
  addItem(item): Observable<Cliente[]>
   {
     
    return this.http.post(`${environment.urlService}/Cliente`,item)
    .pipe(
      map((response:any)=>response));
  }

//funcion para actualizar el estado de los ticket
  updateItemStatus(data):Observable<Response>
  {
    return this.http.put(`${environment.urlService}/Ticket`,data)
    .pipe(
    map((response:any)=>response));
  }
}
