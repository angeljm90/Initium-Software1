using Coworking.Api.Application;
using Coworking.Api.Application.Contracts;
using Indicadores.Api.DataAccess.Contracts.Repositories;
using Indicadores.Api.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Coworking.Api.CrossCutting
{
    public static class IoDRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            AddRegisterServices(services);
            AddRegisterRepositories(services);
            return services;
        }
        private static IServiceCollection AddRegisterServices(IServiceCollection services)
        {
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<ITicketService, TicketService>();
            services.AddTransient<ITipoColasService, TipoColasService>();
           
            return services;
        }
        

        private static IServiceCollection AddRegisterRepositories(IServiceCollection services)
        {
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<ITicketRepository, TicketRepository>();
            services.AddTransient<ITipoColasRepository, TipoColasRepository>();
            
            return services;
        }
    }
}
