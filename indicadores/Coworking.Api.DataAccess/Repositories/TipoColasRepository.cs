using Coworking.Api.DataAccess.Contracts;
using Indicadores.Api.DataAccess.Contracts.Entities;
using Indicadores.Api.DataAccess.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace Indicadores.Api.DataAccess.Repositories
{
  public  class TipoColasRepository : ITipoColasRepository
    {
        //CRUD CREATE READ UPDATE DELETE
        private readonly IIndicadoresContext _indicadoresContext;
        public TipoColasRepository(IIndicadoresContext indicadoresContext)
        {
            _indicadoresContext = indicadoresContext;
        }

        public async Task<IEnumerable<object>> GetAll()
        {
            return await (from t in _indicadoresContext.TipoColas 

                          select new
                          {
                              t.TicId,
                              t.TicNombre,
                              t.TicTiempo
                          }).ToListAsync();
        }

        public async Task<int> Add(TipoColas entity)
        {
            var result = await _indicadoresContext.TipoColas.AddAsync(entity);
            await _indicadoresContext.SaveChangesAsync();
            return result.Entity.TicId;
        }

      

        public async Task<int> Update(TipoColas entity)
        {
            _indicadoresContext.TipoColas.Attach(entity);
           
            await _indicadoresContext.SaveChangesAsync();
            return entity.TicId;
        }
    }
}
