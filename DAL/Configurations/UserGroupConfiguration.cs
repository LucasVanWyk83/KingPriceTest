using KingPriceTest.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingPriceTest.DAL.Configurations
{
    public class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> builder)
        {
            builder.HasKey(k => k.Id);
			
			builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
			
			builder.Property(e => e.GroupId);
			
			builder.Property(e => e.UserId)
                .ValueGeneratedOnAdd();

           	builder.Property(e => e.CreatedDateTime);
			
			builder.Property(e => e.UpdatedDateTime);


            builder.HasData(
                new UserGroup(1, 1, 1, DateTime.Now,null),
				new UserGroup(1, 1, 2, DateTime.Now,null),
				new UserGroup(1, 1, 3, DateTime.Now,null),
				new UserGroup(1, 2, 2, DateTime.Now,null),
				new UserGroup(1, 2, 3, DateTime.Now,null)
				);
                
        }
    }
}