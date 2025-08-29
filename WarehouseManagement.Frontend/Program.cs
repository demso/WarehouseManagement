using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WarehouseManagement.Frontend;
using WarehouseManagement.Frontend.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton<INotificationManager, NotificationManager>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:80/") });

await builder.Build().RunAsync();