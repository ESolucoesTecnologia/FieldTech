using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Repository.Context
{
    public class FieldTechContextFactory : IDesignTimeDbContextFactory<FieldTechContext>
    {
        //public FieldTechContextFactory CreateDbContext(string[] args)
        //{
        //    //var optionsBuilder = new DbContextOptionsBuilder<FieldTechContext>();
        //    //optionsBuilder.UseSqlServer();

        //    //return new FieldTechContext(optionsBuilder.Options);

        //}

        public FieldTechContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FieldTechContext>();
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=DbField;Integrated Security=SSPI;");
            return new FieldTechContext(optionsBuilder.Options);
        }


    }
}
