﻿using System;
using System.Linq;
using KingPriceTest.DAL.Factories;
using FluentAssertions;
using NUnit.Framework;

namespace UnitTests.DBContextTests
{
    [TestFixture]
    public class DBContextTest
    {
        [Test]
        public void SqlServer_Context_Test()
        {
            var factory = new KingPriceTestDbContextFactory();
            var sqlServerContext = factory.CreateDbContext(Array.Empty<string>());
            var user = sqlServerContext.User.First(x => x.Id == 1);
            user.FirstName.Should().Be("Admin");
        }
    }
}