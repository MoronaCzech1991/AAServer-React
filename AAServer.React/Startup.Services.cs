using AAServer.React.Autorizations;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;

namespace AAServer.React
{
    public partial class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

            services.AddSession();
            services.AddMemoryCache();

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

            services.AddMvc(options =>
            {
                options.AllowEmptyInputInBodyModelBinding = true;
                foreach (var formatter in options.InputFormatters)
                {
                    if (formatter.GetType() == typeof(SystemTextJsonInputFormatter))
                        ((SystemTextJsonInputFormatter)formatter).SupportedMediaTypes.Add(
                            Microsoft.Net.Http.Headers.MediaTypeHeaderValue.Parse("text/plain"));
                }
            }).AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            });

            // This part of code insert the interfaces 
            this.InsertInterfaces(services);
        }
    }
}
