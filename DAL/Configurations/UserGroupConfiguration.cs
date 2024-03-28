using KingPriceTest.BLL.Models;
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
			
			builder.Property(e => e.UserId);

           	builder.Property(e => e.CreatedDateTime);
			
			builder.Property(e => e.UpdatedDateTime);
        }
    }
}