using AAServer.Domain.LoginAndIdentificationDo;
using AAServer.Infra.Data.ContextInfra;
using AAServer.Infra.Data.LoginAndIdentificationInfra;
using AAServer.MVC.Autorizations;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using JavaScriptEngineSwitcher.V8;
using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
using React.AspNet;

namespace AAServer.MVC
{
    public partial class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddReact();
            // Make sure a JS engine is registered, or you will get an error!
            services.AddJsEngineSwitcher(options => options.DefaultEngineName = V8JsEngine.EngineName).AddV8();

            // Add use view with controllers 
            services.AddCors();
            services.AddControllersWithViews();
            services.AddDbContext<ContextModelConfigDB>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionDB")));

            // Add sessions
            services.AddSession();
            services.AddMemoryCache();
            services.AddRazorPages();
            services.AddControllers();

            // Autentication
            services.AddAuthentication(AutorizationLevels.NAME_AUTH)
            .AddCookie(AutorizationLevels.NAME_AUTH, options =>
            {
                options.Cookie.Name = AutorizationLevels.NAME_COOKIE;
                options.LoginPath = "/login";
                options.AccessDeniedPath = "/denied";
            });

            services.AddAuthorization(options =>
            {
                // Admin is the master user, can access all level and has all rights
                options.AddPolicy(AutorizationLevels.POLICY_ADMIN_LEVEL, policy => policy.RequireRole(AutorizationLevels.ROLE_ADMIN_LEVEL));

                // Manager is the middle level can do more things then employe level but is limited by the admin
                options.AddPolicy(AutorizationLevels.POLICY_MANAGER_LEVEL, policy => policy.RequireRole(AutorizationLevels.ROLE_MANAGER_LEVEL));

                // Employe is the lowest level, can do only basic things and is limited by the admin and manager user
                options.AddPolicy(AutorizationLevels.POLICY_EMPLOYE_LEVEL, policy => policy.RequireRole(AutorizationLevels.ROLE_EMPLOYE_LEVEL));
            });

            // ASP.NET HttpContext dependency
            services.AddScoped<IUser, AspNetUser>();

            // This part of code insert the interfaces 
            this.InsertInterfaces(services);
        }
    }
}
