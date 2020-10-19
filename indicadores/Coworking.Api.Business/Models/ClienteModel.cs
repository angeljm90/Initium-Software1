using Indicadores.Api.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;

namespace Coworking.Api.Business
{
    public partial class ClienteModel
    {
       

        public int CliId { get; set; }
        public string CliIdentificacion { get; set; }
        public string CliNombre { get; set; }
        public TicketModel ticket { get; set; }
        
        public virtual List<TicketModel> TicketLista { get; set; }
    }
}
