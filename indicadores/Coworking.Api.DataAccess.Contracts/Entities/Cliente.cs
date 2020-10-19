using System;
using System.Collections.Generic;

namespace Indicadores.Api.DataAccess.Contracts.Entities
{
    public partial class Cliente
    {
       
        public int CliId { get; set; }
        public string CliIdentificacion { get; set; }
        public string CliNombre { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
