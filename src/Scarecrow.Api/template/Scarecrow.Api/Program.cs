using Asp.Versioning.ApiExplorer;
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
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        IReadOnlyList<ApiVersionDescription> descriptions = app.DescribeApiVersions();

        foreach (var description in descriptions)
        {
            options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToLowerInvariant());
        }
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseMiddleware<ApiExceptionHandleMiddleware>();
app.UseMiddleware<HttpRequestLoggerMiddleware>();

app.MapControllers();

app.Run();
