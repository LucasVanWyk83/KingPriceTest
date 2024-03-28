using KingPriceTest.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingPriceTest.DAL.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder.Property(e => e.FirstName)
				.IsRequired();

            builder.Property(e => e.LastName)
                .IsRequired();
			
			builder.Property(e => e.Email)
                .IsRequired();

            builder.Property(e => e.Password)
                .IsRequired();
			
			builder.Property(e => e.Approved);
				
			builder.Property(e => e.CreatedDateTime);
			
			builder.Property(e => e.UpdatedDateTime);
                
        }
    }
}