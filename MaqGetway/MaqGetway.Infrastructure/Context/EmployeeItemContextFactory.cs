using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaqGetway.Infrastructure.Context
{
    public class EmployeeItemContextFactory : IDesignTimeDbContextFactory<EmployeeItemContext>
    {
        public EmployeeItemContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<EmployeeItemContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            dbContextOptionsBuilder.UseSqlServer(connectionString);
            return new EmployeeItemContext(dbContextOptionsBuilder.Options);

        }
    }
}
