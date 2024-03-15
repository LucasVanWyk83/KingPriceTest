using KingPriceTest.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingPriceTest.DAL.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name);

           	builder.Property(e => e.CreatedDateTime);
			
			builder.Property(e => e.UpdatedDateTime);



            builder.HasData(
                new Permission(1, "Admin", DateTime.Now,null),
				new Permission(2, "SuperUser", DateTime.Now,null),
				new Permission(3, "User", DateTime.Now,null),
				new Permission(4, "Restricted", DateTime.Now,null)
				);
                
        }
    }
}