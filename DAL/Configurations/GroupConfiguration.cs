using KingPriceTest.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingPriceTest.DAL.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Name);

           	builder.Property(e => e.CreatedDateTime);
			
			builder.Property(e => e.UpdatedDateTime);

            builder.HasData(
                new Group(1, "Administrator", DateTime.Now,null),
				new Group(2, "SuperUser", DateTime.Now,null),
				new Group(3, "User", DateTime.Now,null)
				);
                
        }
    }
}