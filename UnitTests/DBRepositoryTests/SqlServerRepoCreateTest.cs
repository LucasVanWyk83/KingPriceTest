using System;
using System.Linq;
using System.Threading.Tasks;
using KingPriceTest.DAL.Factories;
using KingPriceTest.DAL.Repositories;
using KingPriceTest.BLL.Models;
using FluentAssertions;
using NUnit.Framework;

namespace UnitTests.DBRepositoryTests
{
    [TestFixture]
    public class SqlServerRepoCreateTest
    {
        [Test]
        public async Task SqlServer_User_Repo_Create_Test()
        {
            var factory = new KingPriceTestDbContextFactory();
            var repo = new UserRepository(factory.CreateDbContext(Array.Empty<string>()));
            var user = new User
            {
                FirstName = "Admin2",
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
            getAll.Last().FirstName.Should().Be("Admin2");
        }
		
		//[Test]
  //      public async Task SqlServer_User_Repo_Update_Test()
  //      {
  //          var factory = new KingPriceTestDbContextFactory();
  //          var repo = new UserRepository(factory.CreateDbContext(Array.Empty<string>()));
  //          var user = ;

  //          await repo.AddAsync(user);
  //          var success = await repo.SaveChangesAsync();
  //          success.Should().BeTrue();
  //          var getAll = await repo.GetAllAsync();
  //          getAll.Last().FirstName.Should().Be("Admin2");
  //      }
		
		[Test]
        public async Task SqlServer_Group_Repo_Create_Test()
        {
            var factory = new KingPriceTestDbContextFactory();
            var repo = new GroupRepository(factory.CreateDbContext(Array.Empty<string>()));
            var group = new Group
            {
                Name = "Admin2",
                CreatedDateTime = DateTime.Now,
				UpdatedDateTime = null
            };

            await repo.AddAsync(group);
            var success = await repo.SaveChangesAsync();
            success.Should().BeTrue();
            var getAll = await repo.GetAllAsync();
            getAll.Last().Name.Should().Be("Admin2");
        }
		
		[Test]
        public async Task SqlServer_Permission_Repo_Create_Test()
        {
            var factory = new KingPriceTestDbContextFactory();
            var repo = new PermissionRepository(factory.CreateDbContext(Array.Empty<string>()));
            var permission = new Permission
            {
                Name = "Admin2",
                CreatedDateTime = DateTime.Now,
				UpdatedDateTime = null
            };

            await repo.AddAsync(permission);
            var success = await repo.SaveChangesAsync();
            success.Should().BeTrue();
            var getAll = await repo.GetAllAsync();
            getAll.Last().Name.Should().Be("Admin2");
        }
    }
}