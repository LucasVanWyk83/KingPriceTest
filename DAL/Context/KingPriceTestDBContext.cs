﻿using KingPriceTest.DAL.Configurations;
using KingPriceTest.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace KingPriceTest.DAL.Context
{
    public class KingPriceTestDbContext : DbContext
    {
        public KingPriceTestDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<UserGroup> UserGroup { get; set; }
        public DbSet<GroupPermission> GroupPermission { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new UserGroupConfiguration());
            modelBuilder.ApplyConfiguration(new GroupPermissionConfiguration());
        }
    }
}
