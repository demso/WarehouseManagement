using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Serilog;
using Serilog.Templates;
using Serilog.Templates.Themes;
using WarehouseManagement.Application;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Persistence;
using WarehouseManagement.WebAPI;
using WarehouseManagement.WebAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;

services
    .AddApplication()
    .AddPersistence(configuration)
    .AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

services.AddAutoMapper(config => {
    config.AddMaps(Assembly.GetExecutingAssembly());
    config.AddMaps(typeof(IWarehouseDbContext).Assembly);
});

services.AddSerilog((servicess, lc) => lc
    .ReadFrom.Configuration(configuration)
    .ReadFrom.Services(servicess)
    .Enrich.FromLogContext()
    .WriteTo.Console(new ExpressionTemplate(
        "[{@t:HH:mm:ss} {@l:u3}{#if @tr is not null} ({substring(@tr,0,4)}:{substring(@sp,0,4)}){#end}] {SourceContext} \n{@m}\n{@x}",
        theme: TemplateTheme.Code)));

var app = builder.Build();

await app.InitializeDatabase();
app.UseExceptionHandlerMiddleware();

DisplayRoutes(app);

app.Run();
return;

static void DisplayRoutes(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var apiDescriptionGroupCollectionProvider = 
        scope.ServiceProvider.GetRequiredService<IApiDescriptionGroupCollectionProvider>();

    Console.WriteLine("=== Controller Routes ===");
    foreach (var group in apiDescriptionGroupCollectionProvider.ApiDescriptionGroups.Items)
    {
        foreach (var api in group.Items)
        {
            Console.WriteLine($"{api.HttpMethod?.PadRight(6)} {api.RelativePath}");
        }
    }
}