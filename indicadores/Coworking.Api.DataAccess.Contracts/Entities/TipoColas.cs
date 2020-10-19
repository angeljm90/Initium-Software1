using System;
using System.Collections.Generic;

namespace Indicadores.Api.DataAccess.Contracts.Entities
{
    public partial class TipoColas
    {
      

        public int TicId { get; set; }
        public string TicNombre { get; set; }
        public int? TicTiempo { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
