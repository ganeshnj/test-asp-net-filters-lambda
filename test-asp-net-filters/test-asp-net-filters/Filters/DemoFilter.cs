using Amazon.Lambda.Core;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;

namespace Filters
{
    public class DemoFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            LambdaLogger.Log("DemoFilter.OnActionExecuting");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            LambdaLogger.Log("DemoFilter.OnActionExecuted");
        }
    }
}