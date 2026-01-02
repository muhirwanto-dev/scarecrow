using System.Text.Json.Serialization;
using Scarecrow.Api.Configurations;
using Scarecrow.Api.Routing;

#if !NET10_0_OR_GREATER
using Scarecrow.Api.ApiDocs;
#endif

namespace Scarecrow.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration.Bind);

            services.AddEndpoints();
#if NET10_0_OR_GREATER
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            services.AddOpenApi();
#else
            services.AddSwagger();
#endif
            services.AddProblemDetails();

            return services;
        }

#if !NET10_0_OR_GREATER
        private static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.ConfigureOptions<SwaggerConfiguration>();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(setup =>
            {
                setup.OrderActionsBy(desc => desc.RelativePath);
            });

            return services;
        }
#endif

        private static IServiceCollection AddEndpoints(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                // Customize route & action naming convention
                options.Conventions.Add(new ControllerRoutingConvention());
                options.Conventions.Add(new ActionRoutingConvention());
            })
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                });

            services.AddRouting(config =>
            {
                // All route path become lowercase
                config.LowercaseUrls = true;
            });

            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new Asp.Versioning.ApiVersion(1, 0);
            })
                // This is required for Swagger to work with API versioning
                .AddApiExplorer(options =>
                {
                    options.GroupNameFormat = "'v'VVV"; // Format: v1, v1.0, etc.
                    options.SubstituteApiVersionInUrl = true; // THIS makes {version} become real version like '1'
                });

            return services;
        }
    }
}
