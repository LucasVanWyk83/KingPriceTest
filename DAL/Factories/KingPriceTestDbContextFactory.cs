using System;
using KingPriceTest.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace KingPriceTest.DAL.Factories
{
    public class KingPriceTestDbContextFactory : IDesignTimeDbContextFactory<KingPriceTestDbContext>
    {
        public KingPriceTestDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<KingPriceTestDbContext>();
            var connectionString = Environment.GetEnvironmentVariable("SQLSERVER_LOCAL_CONNSTR");
           // optionsBuilder.(connectionString
            //                            ?? throw new NullReferenceException(
            //                                $"Connection string is not got from environment {nameof(connectionString)}"));

            return new KingPriceTestDbContext(optionsBuilder.Options);
        }
    }
}