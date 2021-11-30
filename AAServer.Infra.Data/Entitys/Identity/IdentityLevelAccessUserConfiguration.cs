using AAServer.Domain.IdentityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AAServer.Infra.Data.Entitys.Identity
{
    public class IdentityLevelAccessUserConfiguration : IEntityTypeConfiguration<IdentityLevelAccessUser>
    {
        public void Configure(EntityTypeBuilder<IdentityLevelAccessUser> builder)
        {
            builder.ToTable("ITIdentityLevelAccessUser");
        }
    }
}
