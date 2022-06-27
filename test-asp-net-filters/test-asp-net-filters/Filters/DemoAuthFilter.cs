using Amazon.Lambda.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;

namespace Filters
{
    public class DemoAuthFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            LambdaLogger.Log("DemoAuthFilter.OnAuthorization");

            context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
        }
    }
}