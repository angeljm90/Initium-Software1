
using Indicadores.Api.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Coworking.Api.DataAccess.Contracts
{
    public interface IIndicadoresContext
    {
        DbSet<Cliente> Cliente { get; set; }
        DbSet<Ticket> Ticket { get; set; }
         DbSet<TipoColas> TipoColas { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);
        EntityEntry Entry(object entity);
    }
}
