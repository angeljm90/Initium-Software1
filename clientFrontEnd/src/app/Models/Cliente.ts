import { Ticket } from './Ticket';

export interface Cliente
{
     cliId ?:number
     cliIdentificacion? :string
     cliNombre ?:string
     ticket?:Ticket

}