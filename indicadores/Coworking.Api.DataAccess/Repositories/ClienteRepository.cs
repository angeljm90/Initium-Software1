using Coworking.Api.DataAccess.Contracts;
using Indicadores.Api.DataAccess.Contracts.Entities;
using Indicadores.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Indicadores.Api.DataAccess.Repositories
{
  public  class ClienteRepository : IClienteRepository
    {
        //CRUD CREATE READ UPDATE DELETE
        private readonly IIndicadoresContext _indicadoresContext;
        public ClienteRepository(IIndicadoresContext indicadoresContext)
        {
            _indicadoresContext = indicadoresContext;
        }
        public async Task<Cliente> Exist(string identificacion)
        {
            return _indicadoresContext.Cliente
                .Where(x => x.CliIdentificacion == identificacion)
                .Select(x => new Cliente { CliId = x.CliId })
                .FirstOrDefault();
        }

        public async Task<IEnumerable<object>> GetAll()
        {
            return await (from ti in _indicadoresContext.Ticket
                          join  c in _indicadoresContext.Cliente on ti.CliId equals c.CliId
                          join t in _indicadoresContext.TipoColas on ti.TicId equals t.TicId
                          where ti.TikEstado==0
                          select new
                          {
                               c.CliId,
                              t.TicId,
                              ti.TikId,
                             t.TicNombre,
                               c.CliIdentificacion,
                               c.CliNombre, 
                               t.TicTiempo,
                               ti.TikEstado,
                          }).ToListAsync();
        }

        public async Task<int> Add(Cliente entity)
        {
            var result = await _indicadoresContext.Cliente.AddAsync(entity);
            await _indicadoresContext.SaveChangesAsync();
            return result.Entity.CliId;
        }

      

        public async Task<int> Update(Cliente entity)
        {
            _indicadoresContext.Cliente.Attach(entity);
            _indicadoresContext.Entry(entity).Property("CliEstado").IsModified = true;
            await _indicadoresContext.SaveChangesAsync();
            return entity.CliId;
        }
    }
}
