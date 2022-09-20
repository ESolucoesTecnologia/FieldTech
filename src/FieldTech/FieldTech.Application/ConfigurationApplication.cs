using FieldTech.Application.Field.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application
{
    public static class ConfigurationApplication
    {

        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Application.ConfigurationApplication).Assembly);

            //services.AddMediatR(typeof(Application.ConfigurationApplication).Assembly);

            services.AddScoped<ITecnicoService, TecnicoService>();
            

            return services;
        }



    }
}
