using AAServer.Domain.IdentityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Identity
{
    public class IdentityAccountConfiguration : IEntityTypeConfiguration<IdentityAccount>
    {
        public void Configure(EntityTypeBuilder<IdentityAccount> builder)
        {
            builder.ToTable("ITIdentityAccount");
        }
    }
}
