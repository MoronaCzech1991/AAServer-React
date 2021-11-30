using AAServer.Domain.UserDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Primary Key
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("ID_USER")
                .IsRequired();

            // Code Tenant
            builder.Property(x => x.CodeTenantUser)
                .HasColumnName("CODE_TENANT_USER")
                .IsRequired();

            builder.Property(x => x.NameUser)
                .HasColumnName("NAME_USER")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Email)
                .HasColumnName("EMAIL_USER")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Password)
                .HasColumnName("PASSWORD_USER")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.Level)
                .HasColumnName("LEVEL_USER")
                .IsRequired();

            builder.Property(x => x.IsActive)
                .HasColumnName("IS_ACTIVE_USER")
                .IsRequired();

            builder.HasOne(x => x.AccountUser)
                   .WithMany(c => c.Users)
                   .HasForeignKey(u => u.CodeTenantUser);
            
            // Table
            builder.ToTable("TUser");
        }
    }
}
