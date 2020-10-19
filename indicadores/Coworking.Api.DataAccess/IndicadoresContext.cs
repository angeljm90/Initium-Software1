using Coworking.Api.DataAccess.Contracts;
using Indicadores.Api.DataAccess.Contracts.Entities;
using Indicadores.Api.DataAccess.EntityConfig;
using Indicadores.Api.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Coworking.Api.DataAccess
{
    public  class IndicadoresContext : DbContext, IIndicadoresContext
    {
        public IndicadoresContext(DbContextOptions options) : base(options)
        {
        }


        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TipoColas> TipoColas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           ClienteEntityConfig.SetEntityBuilder(modelBuilder.Entity<Cliente>());

            TicketEntityConfig.SetEntityBuilder(modelBuilder.Entity<Ticket>());

            TipoColasEntityConfig.SetEntityBuilder(modelBuilder.Entity<TipoColas>());
      

            base.OnModelCreating(modelBuilder);
        }

    }
}
