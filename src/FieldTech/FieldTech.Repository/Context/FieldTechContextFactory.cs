using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Repository.Context
{
    public class FieldTechContextFactory : IDesignTimeDbContextFactory<FieldTechContext>
    {
        public FieldTechContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json")
                        .Build();
            var connectionString = configuration.GetConnectionString("FieldTech");


            var optionsBuilder = new DbContextOptionsBuilder<FieldTechContext>();
            optionsBuilder.UseSqlServer(connectionString);            
            return new FieldTechContext(optionsBuilder.Options);
        }
        



    }
}
