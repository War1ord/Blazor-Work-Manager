using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WorkManager.Web.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
