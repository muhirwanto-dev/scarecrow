using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Templator.Application.Common.Behaviors;
using Templator.Application.Common.Mapping;
using Templator.Application.Interfaces;

namespace Templator.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddValidatorsFromAssemblyContaining(typeof(DependencyInjection));
            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
                options.AddOpenBehavior(typeof(ValidationBehavior<,>));
            });

            return services
                .AddMapping();
        }

        private static IServiceCollection AddMapping(this IServiceCollection services)
        {
            services.AddSingleton<IMapper, Mapper>();

            return services;
        }
    }
}
