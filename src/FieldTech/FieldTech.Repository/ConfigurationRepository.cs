using FieldTech.Domain.Field.Repository;
using FieldTech.Domain.Fornecedor.Repository;
using FieldTech.Domain.OrdemServico.Repository;
using FieldTech.Repository.Context;
using FieldTech.Repository.Database;
using FieldTech.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Repository
{
    public static  class ConfigurationRepository
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<FieldTechContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));
            services.AddScoped<ITecnicoRepository, TecnicoRepository>();
            services.AddScoped<IOrdemRepository, OrdemRepository>();
            services.AddScoped<IOrdemDetalheRepository, OrdemDetalheRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();



            return services;
        }




    }
}
