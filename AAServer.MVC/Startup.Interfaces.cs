using AAServer.Application.AccountAp;
using AAServer.Application.Provision;
using AAServer.Application.Sys.Modules.RawMaterialSys.RawMaterialAp;
using AAServer.Application.Sys.Modules.Register.ClientAp;
using AAServer.Application.Translation;
using AAServer.Application.Translation.FactoryTranslation;
using AAServer.Application.UserAp;
using AAServer.Domain.AccountDo;
using AAServer.Domain.IdentityModels.Account;
using AAServer.Domain.IdentityModels.LevelAccess;
using AAServer.Domain.MessagesWarnings.PT;
using AAServer.Domain.Sys.Modules.RawMaterialDo;
using AAServer.Domain.Sys.Modules.Register.ClientDo;
using AAServer.Domain.UserDo;
using AAServer.Infra.Data.Reps.AccountInfra;
using AAServer.Infra.Data.Reps.IdentityInfra.Account;
using AAServer.Infra.Data.Reps.IdentityInfra.LevelAccess;
using AAServer.Infra.Data.Reps.Sys.Modules.RawMaterialSys.RawMaterialInfra;
using AAServer.Infra.Data.Reps.Sys.Modules.Register.ClientInfra;
using AAServer.Infra.Data.Reps.UserInfra;
using Microsoft.Extensions.DependencyInjection;

namespace AAServer.MVC
{
    public partial class Startup
    {
        public void InsertInterfaces(IServiceCollection services)
        {
            // Interfaces

            // Application 
            services.AddTransient<IAplicAccount, AplicAccount>();
            services.AddTransient<IAplicUser, AplicUser>();
            services.AddTransient<IAplicProvision, AplicProvision>();
            services.AddTransient<IAplicTranslation, AplicTranslation>();
            services.AddTransient<IAplicRawMaterial, AplicRawMaterial>();

            // Regist Application
            services.AddTransient<IAplicClient, AplicClient>();

            // Repositories
            services.AddTransient<IRepIdentityAccount, RepIdentityAccount>();
            services.AddTransient<IRepIdentityLevelAccessUser, RepIdentityLevelAccessUser>();
            services.AddTransient<IRepUser, RepUser>();
            services.AddTransient<IRepAccount, RepAccount>();
            services.AddTransient<IRepRawMaterial, RepRawMaterial>();

            // Register Repositories
            services.AddTransient<IRepClient, RepClient>();

            // Factories
            services.AddTransient<IFactoryObjectTranslation, FactoryObjectTranslation>();

            // Messages
            services.AddTransient<IPortugueseMessages, PortugueseMessages>();
        }
    }
}
