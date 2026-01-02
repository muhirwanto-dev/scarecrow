#if !NET10_0_OR_GREATER
using Asp.Versioning.ApiExplorer;
#endif
using Scarecrow.Api;
using Scarecrow.Api.Middlewares;
using Scarecrow.Application;
using Scarecrow.Infrastructure;
using SingleScope.Persistence.EFCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddPresentation(builder.Configuration)
    .AddApplication(builder.Configuration)
    .AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.Services.UseSingleScopePersistence();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
#if NET10_0_OR_GREATER
    app.MapOpenApi();
#else
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        IReadOnlyList<ApiVersionDescription> descriptions = app.DescribeApiVersions();

        foreach (var description in descriptions)
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToLowerInvariant());
        }
    });
#endif
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseMiddleware<ApiExceptionHandleMiddleware>();
app.UseMiddleware<HttpRequestLoggerMiddleware>();

app.MapControllers();

app.Run();
