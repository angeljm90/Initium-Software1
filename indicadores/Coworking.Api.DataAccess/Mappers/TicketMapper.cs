using Coworking.Api.Business;
using Indicadores.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Indicadores.Api.DataAccess.Mappers
{
  public  class TicketMapper
    {
        public static Ticket Map(TicketModel dto)
        {
            return new Ticket()
            {
                TikId = dto.TikId,
                CliId = dto.CliId,
                TicId = dto.TicId,
                TikFechaRegistro = dto.TikFechaRegistro,
                TikFechaAtendido = dto.TikFechaAtendido,
                TikEstado = dto.TikEstado,

            };
        }
        
    }
}


