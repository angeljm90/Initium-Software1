using System;
using System.Collections.Generic;

namespace Indicadores.Api.DataAccess.Contracts.Entities
{
    public partial class Ticket
    {
        public int TikId { get; set; }
        public int? CliId { get; set; }
        public int? TicId { get; set; }
        public DateTime? TikFechaRegistro { get; set; }
        public DateTime? TikFechaAtendido { get; set; }
        public int? TikEstado { get; set; }

        public virtual Cliente Cli { get; set; }
        public virtual TipoColas Tic { get; set; }
    }
}
