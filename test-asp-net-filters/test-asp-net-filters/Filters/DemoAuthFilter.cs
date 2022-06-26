using Amazon.Lambda.Core;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;

namespace Filters
{
    public class DemoAuthFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            LambdaLogger.Log("DemoAuthFilter.OnAuthorization");
        }
    }
}