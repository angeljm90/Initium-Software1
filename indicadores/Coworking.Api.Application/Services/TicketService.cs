using Coworking.Api.Application.Contracts;
using Indicadores.Api.DataAccess.Contracts.Entities;
using Indicadores.Api.DataAccess.Contracts.Repositories;
using Indicadores.Api.DataAccess.Mappers;
using Indicadores.Api.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Application
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public async Task<int> Add(TicketModel ticketiewmodels)
        {
            ticketiewmodels.TikEstado = 0;
            ticketiewmodels.TikFechaRegistro = DateTime.Now;
            var addEntity = await _ticketRepository.Add(TicketMapper.Map(ticketiewmodels));
           
             return addEntity;
        }
        public async Task<int> UpdateTicket(TicketModel ticketViewmodels)
        {
            ticketViewmodels.TikFechaAtendido = DateTime.Now;
            var update = await _ticketRepository.Update(TicketMapper.Map(ticketViewmodels));
            return update;
        }
    }
}
