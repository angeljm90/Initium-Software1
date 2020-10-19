
using Indicadores.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Indicadores.Api.DataAccess.EntityConfig
{
   public  class TicketEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(e => e.TikId);

            builder.ToTable("ticket");

            builder.Property(e => e.TikId).HasColumnName("tik_id");

            builder.Property(e => e.CliId).HasColumnName("cli_id");

            builder.Property(e => e.TicId).HasColumnName("tic_id");

            builder.Property(e => e.TikEstado).HasColumnName("tik_estado");

            builder.Property(e => e.TikFechaAtendido).HasColumnName("tik_fecha_atendido");

            builder.Property(e => e.TikFechaRegistro).HasColumnName("tik_fecha_registro");

            builder.HasOne(d => d.Cli)
                .WithMany(p => p.Ticket)
                .HasForeignKey(d => d.CliId)
                .HasConstraintName("FK_ticket_cliente");

            builder.HasOne(d => d.Tic)
                .WithMany(p => p.Ticket)
                .HasForeignKey(d => d.TicId)
                .HasConstraintName("FK_ticket_tipo_colas");
        }
    }
}
