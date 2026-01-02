using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Scarecrow.Api.ApiDocs
{
    public class SwaggerConfiguration(
        IApiVersionDescriptionProvider _provider
        ) : IConfigureOptions<SwaggerGenOptions>
    {
        public void Configure(SwaggerGenOptions options)
        {
            foreach (ApiVersionDescription description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, new OpenApiInfo
                {
                    Title = AppDomain.CurrentDomain.FriendlyName,
                    Version = description.ApiVersion.ToString(),
                });
            }
        }
    }
}