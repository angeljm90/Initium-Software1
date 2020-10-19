using Coworking.Api.Application.Contracts;
using Coworking.Api.Business;
using Indicadores.Api.DataAccess.Contracts.Repositories;
using Indicadores.Api.DataAccess.Mappers;
using Indicadores.Api.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coworking.Api.Application
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ITicketService  _ticketService;

        public ClienteService(IClienteRepository clienteRepository, ITicketService ticketService)
        {
            _clienteRepository = clienteRepository;
            _ticketService = ticketService;
        } 
        public async Task<IEnumerable<object>> GetAll()
        {
            return await _clienteRepository.GetAll();
        }

        public async Task<int> AddCliente(ClienteModel clienteViewmodels)
        {

            var addEntity = await _clienteRepository.Add(ClienteMapper.Map(clienteViewmodels));
            clienteViewmodels.ticket.CliId = addEntity;
            await _ticketService.Add(clienteViewmodels.ticket);
            return addEntity;
        }

        public async Task<int> UpdateCliente(ClienteModel clienteViewmodels)
        {
            var update = await _clienteRepository.Update(ClienteMapper.Map(clienteViewmodels));
            return update;
        }
    }
}
