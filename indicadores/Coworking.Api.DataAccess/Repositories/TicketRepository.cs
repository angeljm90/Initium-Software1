using Coworking.Api.DataAccess.Contracts;
using Indicadores.Api.DataAccess.Contracts.Entities;
using Indicadores.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Indicadores.Api.DataAccess.Repositories
{
  public  class TicketRepository : ITicketRepository
    {
        //CRUD CREATE READ UPDATE DELETE
        private readonly IIndicadoresContext _indicadoresContext;
        public TicketRepository(IIndicadoresContext indicadoresContext)
        {
            _indicadoresContext = indicadoresContext;
        }
      

       

        public async Task<int> Add(Ticket entity)
        {
            try
            {
                var result = await _indicadoresContext.Ticket.AddAsync(entity);
                await _indicadoresContext.SaveChangesAsync();
                return result.Entity.TikId;
            }
            catch(Exception e)
            {
                return 1;
            }
            
        }

      

        public async Task<int> Update(Ticket entity)
        {
            _indicadoresContext.Ticket.Attach(entity);
            _indicadoresContext.Entry(entity).Property("TikEstado").IsModified = true;
            await _indicadoresContext.SaveChangesAsync();
            return entity.TikId;
        }
    }
}
