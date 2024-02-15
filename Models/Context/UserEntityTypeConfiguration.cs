using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WebDevelopment.Models.Entities;

namespace WebDevelopment.Models.Context
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasIndex(p => p.UserName).IsUnique();
            builder.Property(op => op.UserName)
           .HasColumnName("username")
           .HasColumnType("varchar(255)");
        }
    }
}
