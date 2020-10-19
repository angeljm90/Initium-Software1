using Coworking.Api.Business;
using Indicadores.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Indicadores.Api.DataAccess.Mappers
{
  public  class TipoColasMapper
    {
        public static TipoColas Map(TipoColasModel dto)
        {
            return new TipoColas()
            {
               TicId =dto.TicId,
         TicNombre = dto.TicNombre,
        TicTiempo=dto.TicTiempo
            

    };
        }
    }
}


