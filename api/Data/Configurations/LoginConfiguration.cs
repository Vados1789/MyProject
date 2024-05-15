using api.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace api.Data.Configurations
{
    public class LoginConfiguration : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            // Configure the column name and relationship
            builder.Property(l => l.ProfileId).HasColumnName("profile_id");
            builder.HasOne(l => l.Profile)
                    .WithOne(p => p.Login)
                    .HasForeignKey<Login>(l => l.ProfileId)
                    .IsRequired();

            // Other configurations...
        }
    }
}
