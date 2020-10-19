using Coworking.Api.Business;
using System;
using System.Collections.Generic;

namespace Indicadores.Api.DataAccess.Contracts.Entities
{
    public partial class TicketModel
    {
        public int TikId { get; set; }
        public int? CliId { get; set; }
        public int? TicId { get; set; }
        public DateTime? TikFechaRegistro { get; set; }
        public DateTime? TikFechaAtendido { get; set; }
        public int? TikEstado { get; set; }

        public virtual ClienteModel Cli { get; set; }
        public virtual TipoColasModel Tic { get; set; }
    }
}
