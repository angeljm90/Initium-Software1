using System;
using System.Collections.Generic;

namespace Indicadores.Api.DataAccess.Contracts.Entities
{
    public partial class TipoColasModel
    {
       

        public int TicId { get; set; }
        public string TicNombre { get; set; }
        public int? TicTiempo { get; set; }

        public virtual List<TicketModel> Ticket { get; set; }
    }
}
