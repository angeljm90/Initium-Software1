using Coworking.Api.Business;
using Indicadores.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Indicadores.Api.DataAccess.Mappers
{
  public  class ClienteMapper
    {
        public static Cliente Map(ClienteModel dto)
        {
            return new Cliente()
            {
                CliId =dto.CliId,
        CliIdentificacion = dto.CliIdentificacion,
         CliNombre=dto.CliNombre

    };
        }
    }
}


