using KingPriceTest.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingPriceTest.DAL.Configurations
{
    public class GroupPermissionConfiguration : IEntityTypeConfiguration<GroupPermission>
    {
        public void Configure(EntityTypeBuilder<GroupPermission> builder)
        {
            builder.HasKey(k => k.Id);
			
			builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
			
			builder.Property(e => e.GroupId);

            builder.Property(e => e.PermissionId);

           	builder.Property(e => e.CreatedDateTime);
			
			builder.Property(e => e.UpdatedDateTime); 
        }
    }
}