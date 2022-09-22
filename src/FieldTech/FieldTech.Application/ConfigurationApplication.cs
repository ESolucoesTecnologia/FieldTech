using FieldTech.Application.Field.Service;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace FieldTech.Application
{
    public static class ConfigurationApplication
    {

        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Application.ConfigurationApplication).Assembly);

            services.AddMediatR(typeof(Application.ConfigurationApplication).Assembly);

            services.AddScoped<ITecnicoService, TecnicoService>();
            

            return services;
        }



    }
}
