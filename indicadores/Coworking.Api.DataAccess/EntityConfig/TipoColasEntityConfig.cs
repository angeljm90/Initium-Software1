
using Indicadores.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Indicadores.Api.DataAccess.EntityConfig
{
   public  class TipoColasEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<TipoColas> builder)
        {
            builder.HasKey(e => e.TicId);

            builder.ToTable("tipo_colas");

            builder.Property(e => e.TicId).HasColumnName("tic_id");

            builder.Property(e => e.TicNombre)
                .HasColumnName("tic_nombre")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.TicTiempo).HasColumnName("tic_tiempo");





        }
    }
}
