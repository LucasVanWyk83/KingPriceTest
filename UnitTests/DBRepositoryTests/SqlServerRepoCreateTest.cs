using System;
using System.Linq;
using System.Threading.Tasks;
using KingPriceTest.DAL.Factories;
using KingPriceTest.DAL.Repositories;
using KingPriceTest.DAL.Models;
using FluentAssertions;
using NUnit.Framework;

namespace UnitTests.DBRepositoryTests
{
    [TestFixture]
    public class SqlServerRepoCreateTest
    {
        [Test]
        public async Task SqlServer_Repo_Create_Test()
        {
            var factory = new KingPriceTestDbContextFactory();
            var repo = new UserRepository(factory.CreateDbContext(Array.Empty<string>()));
            var user = new User
            {
                FirstName = "Admin",
                LastName = "Admin",
                Email = "admin@admin.com",
				Password = "admin",
				Approved = true,
				CreatedDateTime = DateTime.Now,
				UpdatedDateTime = null
            };

            await repo.AddAsync(user);
            var success = await repo.SaveChangesAsync();
            success.Should().BeTrue();
            var getAll = await repo.GetAllAsync();
            getAll.Last().FirstName.Should().Be("Admin");
        }
    }
}