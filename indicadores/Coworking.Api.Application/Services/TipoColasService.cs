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
    public class TipoColasService : ITipoColasService
    {
        private readonly ITipoColasRepository _tipoColasRepository;

        public TipoColasService(ITipoColasRepository tiposColasRepository)
        {
            _tipoColasRepository = tiposColasRepository;
        } 
        public async Task<IEnumerable<object>> GetAll()
        {
            return await _tipoColasRepository.GetAll();
        }
        public async Task<int> AddTipoColas(TipoColasModel clienteViewmodels)
        {

            var addEntity = await _tipoColasRepository.Add(TipoColasMapper.Map(clienteViewmodels));

            return addEntity;
        }

        public async Task<int> UpdateTipoColas(TipoColasModel clienteViewmodels)
        {
            var update = await _tipoColasRepository.Update(TipoColasMapper.Map(clienteViewmodels));
            return update;
        }
    }
}
