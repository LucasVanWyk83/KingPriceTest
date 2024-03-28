using System;
using KingPriceTest.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;

namespace KingPriceTest.DAL.Factories
{
    public class KingPriceTestDbContextFactory : IDesignTimeDbContextFactory<KingPriceTestDbContext>
    {
        public KingPriceTestDbContext CreateDbContext(string[] args)
        {
			IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../API/appsettings.json").Build(); 
			var builder = new DbContextOptionsBuilder<KingPriceTestDbContext>(); 
			var connectionString = configuration.GetConnectionString("DatabaseConnection"); 
			builder.UseSqlServer(connectionString); 
			
			return new KingPriceTestDbContext(builder.Options);
        }
    }
}