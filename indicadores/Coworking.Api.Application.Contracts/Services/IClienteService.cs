using Coworking.Api.Business;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts
{
   public interface IClienteService 
    {
       
        Task<IEnumerable<object>> GetAll();



        Task<int> AddCliente(ClienteModel clienteModel);
        Task<int> UpdateCliente(ClienteModel clienteModel);
    }
}
