using HVexTransformer.Infra.Context;
using HVexTransformerInfra.Data.Repositories;
using HVexTransformer.Infra.Data.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HVexTransformer.Domain.Interfaces.Repositories;
using HVexTransformer.Application.Mappings;
using HVexTransformer.Application.Interfaces.Services;
using HVexTransformer.Application.Services;

namespace HVexTransformer.CrossCutting.InversionOfControl;

public static class DependencyInjection
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(_ =>
        {
            var section = configuration.GetSection("HVexDatabase");
            return new HVexDatabaseSettings()
            {
                ConnectionString = section.GetValue<string>("ConnectionString"),
                DatabaseName = section.GetValue<string>("DatabaseName"),
                UserCollectionName = section.GetValue<string>("UserCollectionName"),
                TransformerCollectionName = section.GetValue<string>("TransformerCollectionName"),
                TestCollectionName = section.GetValue<string>("TestCollectionName"),
                ReportCollectionName = section.GetValue<string>("ReportCollectionName"),
            };
        });

        services.AddScoped<HVexDbContext>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

        return services;
    }
}
