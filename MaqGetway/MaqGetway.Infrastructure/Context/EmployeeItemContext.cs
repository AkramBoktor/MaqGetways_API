using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MaqGetway.Domain.Entities;
using System;


namespace MaqGetway.Infrastructure.Context
{
    public class EmployeeItemContext : DbContext
    {
        public EmployeeItemContext(DbContextOptions<EmployeeItemContext> options) : base(options)
        {

        }
        //protected readonly IConfiguration Configuration;

        ////public JsonItemContext(IConfiguration configuration)
        ////{
        ////    Configuration = configuration;
        ////}
        ////protected override void OnConfiguring(DbContextOptions options)
        ////{
        ////    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        //}

        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasKey(table => new { table.Id, table.Name });
        }
    }
}