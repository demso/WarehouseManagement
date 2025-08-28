using System.Reflection;
using System.Text.Json.Serialization;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using WarehouseManagement.Application.Common.Behaviors;

namespace WarehouseManagement.Application;

public static class DependencyInjection {
    public static IServiceCollection AddApplication(this IServiceCollection services) {
        services
            .AddMediatR(options => options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()))
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>))
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly())
            .AddAutoMapper(options => options.AddMaps(Assembly.GetExecutingAssembly()));
        
        return services;
    }
}
