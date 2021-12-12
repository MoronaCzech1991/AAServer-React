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

            // This part of code insert the interfaces 
            this.InsertInterfaces(services);
        }
    }
}
