using Coworking.Api.Business;
using Indicadores.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts
{
   public interface ITicketService 
    {
        Task<int> Add(TicketModel ticketiewmodels);

        Task<int> UpdateTicket(TicketModel clienteViewmodels);
    }
}
