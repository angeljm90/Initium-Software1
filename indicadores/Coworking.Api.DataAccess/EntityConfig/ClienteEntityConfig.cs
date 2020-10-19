
using Indicadores.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Indicadores.Api.DataAccess.EntityConfig
{
   public  class ClienteEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.CliId);

            builder.ToTable("cliente");

            builder.Property(e => e.CliId).HasColumnName("cli_id");

            builder.Property(e => e.CliIdentificacion)
                .HasColumnName("cli_identificacion")
                .HasMaxLength(25)
                .IsUnicode(false);

            builder.Property(e => e.CliNombre)
                .HasColumnName("cli_nombre")
                .HasMaxLength(150)
                .IsUnicode(false);

        }
    }
}
