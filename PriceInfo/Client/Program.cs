using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PriceInfo;
using PriceInfo.Services;
using Syncfusion.Blazor;

namespace PriceInfo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Register Syncfusion license
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(builder.Configuration.GetValue<string>("SyncFusionLicenseKey"));


            builder.RootComponents.Add<App>("#app");
            
            builder.Services.AddScoped(sp =>
            new HttpClient()
            //{
            //    BaseAddress = new Uri("https://api.energidataservice.dk/dataset")
            //}
            );
            builder.Services.AddSyncfusionBlazor();
            await builder.Build().RunAsync();

        }
    }
}