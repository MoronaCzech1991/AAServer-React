using AAServer.Domain.AccountDo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            // Primary Key
            builder.HasKey(x => x.Tenant);
            builder.Property(x => x.Tenant)
                .HasColumnName("TENANT")
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName("NAME_ACCOUNT")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.AccountDate)
                .HasColumnName("DATE_ACCOUNT")
                .IsRequired();

            builder.Property(x => x.IsActive)
                .HasColumnName("IS_ACTIVE_ACCOUNT")
                .IsRequired();

            builder.HasMany(x => x.Users)
                   .WithOne(c => c.AccountUser);

            builder.ToTable("TAccount");
        }
    }
}
