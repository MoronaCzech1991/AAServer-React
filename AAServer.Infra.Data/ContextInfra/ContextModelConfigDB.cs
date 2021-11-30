using AAServer.Domain.AccountDo;
using AAServer.Domain.IdentityModels;
using AAServer.Domain.Sys.Modules.ProductSys.ProductDo;
using AAServer.Domain.Sys.Modules.RawMaterialDo;
using AAServer.Domain.Sys.Modules.Register.ClientDo;
using AAServer.Domain.Sys.Modules.Register.ClientDo.ClientAddressDo;
using AAServer.Domain.Sys.Modules.Register.EmployeDo;
using AAServer.Domain.Sys.Modules.Register.EmployeDo.EmployeAddressDo;
using AAServer.Domain.Sys.Modules.Register.ProviderDo;
using AAServer.Domain.Sys.Modules.Register.ProviderDo.OtherContactProviderDo;
using AAServer.Domain.Sys.Modules.Register.ProviderDo.ProviderAddressDo;
using AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo;
using AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo.ShippingCompanyAddressDo;
using AAServer.Domain.Sys.Modules.Register.ShippingCompanyDo.ShippingCompanyContactDo;
using AAServer.Domain.Sys.Modules.ServiceSys.ServiceDo;
using AAServer.Domain.UserDo;
using AAServer.Infra.Data.Entitys;
using AAServer.Infra.Data.Entitys.Identity;
using AAServer.Infra.Data.Entitys.Sys.Modules.ProductSys.ProductIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.RawMaterialSys.RawMaterialIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.ClientIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.ClientIdConfig.ClientAddressIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.EmployeIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.EmployeIdConfig.EmployeAddressIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.ProviderIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.ProviderIdConfig.OtherContactProviderIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.ProviderIdConfig.ProviderAddressIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.ShippingCompanyIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.ShippingCompanyIdConfig.RepShippingCompanyAddressIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.Register.ShippingCompanyIdConfig.RepShippingCompanyContactIdConfig;
using AAServer.Infra.Data.Entitys.Sys.Modules.ServiceSys.ServiceIdConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AAServer.Infra.Data.ContextInfra
{
    public class ContextModelConfigDB : IdentityDbContext<IdentityAccount, IdentityLevelAccessUser, string>
    {
        const string NAME_DATABASE = @"Server=localhost\MSSQLSERVER03;Database=AAServer;Trusted_Connection=True;";
        public ContextModelConfigDB(DbContextOptions<ContextModelConfigDB> context)
            : base(context)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(NAME_DATABASE);
        }

        public DbSet<IdentityAccount> IdentityAccountsDomains { get; set;}
        public DbSet<IdentityLevelAccessUser> IdentityLevelAccessUsersDomains { get; set; }
        public DbSet<Account> AccountsDomains { get; set; }
        public DbSet<User> UserDomains { get; set; }

        // Models of Sys
        // Register

        // Client
        public DbSet<Client> ClientDomains { get; set; }
        public DbSet<ClientAddress> ClientAddresses { get; set; }

        // Employe
        public DbSet<Employe> EmployeDomanis { get; set; }
        public DbSet<EmployeAddress> EmployeAddressesDomanis { get; set; }

        // Providers
        public DbSet<Provider> ProviderDomains { get; set; }
        public DbSet<OtherContactProvider> OtherContactProviderDomains { get; set; }
        public DbSet<ProviderAddress> ProviderAddressDomains { get; set; }

        // Shipping Companies
        public DbSet<ShippingCompany> ShippingCompaniesDomains { get; set; }
        public DbSet<ShippingCompanyAddress> ShippingCompanyAddressesDomains { get; set; }
        public DbSet<ShippingCompanyContact> ShippingCompanyContactDomains { get; set; }

        // Service
        public DbSet<Service> ServiceDomains { get; set; }

        // Produt
        public DbSet<Product> ProductDomains { get; set; }
        public DbSet<RawMaterial> RawMaterialDomains { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new IdentityAccountConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityLevelAccessUserConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            // Models of Sys
            // Register

            // Client
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new ClientAddressConfiguration());

            // Employe
            modelBuilder.ApplyConfiguration(new EmployeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeAddressConfiguration());

            // Provider
            modelBuilder.ApplyConfiguration(new ProviderConfiguration());
            modelBuilder.ApplyConfiguration(new OtherContactProviderConfiguration());
            modelBuilder.ApplyConfiguration(new ProviderAddressConfiguration());

            // Shipping Company
            modelBuilder.ApplyConfiguration(new ShippingCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new ShippingCompanyAddressConfiguration());
            modelBuilder.ApplyConfiguration(new ShippingCompanyContactConfiguration());

            // Service
            modelBuilder.ApplyConfiguration(new ServiceConfiguration());

            // Product
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RawMaterialConfiguration());      
        }
    }
}
