using Coworking.Api.Business;
using Indicadores.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Indicadores.Api.DataAccess.Contracts.Repositories
{
  public  interface IClienteRepository: IRepository<Cliente>
    {

        Task<IEnumerable<object>> GetAll();

    }
}
