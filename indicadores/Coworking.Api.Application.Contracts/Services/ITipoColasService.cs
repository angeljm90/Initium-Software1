using Coworking.Api.Business;
using Indicadores.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coworking.Api.Application.Contracts
{
   public interface ITipoColasService 
    {
       
        Task<IEnumerable<object>> GetAll();
        Task<int> AddTipoColas(TipoColasModel tipoColasModel);
        Task<int> UpdateTipoColas(TipoColasModel tipoColasModel);
    }
}
