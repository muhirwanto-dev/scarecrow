using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using System.Web;

namespace Scarecrow.Api.Common.Extensions
{
    public static class StringExtensions
    {
        [return: NotNullIfNotNull("origin")]
        public static string? ToKebabCase(this string? origin)
        {
            if (string.IsNullOrEmpty(origin))
            {
                return origin;
            }

            return Regex.Replace(origin, "[a-zA-Z]+(?=(?:[^{}]*{[^{}]*})*[^{}]*$)", (Match match) => Regex.Replace(match.Value, "([a-z])([A-Z])", "$1-$2").ToLower());
        }

        [return: NotNullIfNotNull("message")]
        public static string? Sanitize(this string? message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return message;
            }

            message = message.Replace("\n", "\\n").Replace("\r", "\\r");
            message = HttpUtility.HtmlEncode(message);
            return message;
        }
    }
}
