using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WEB_API_CORE_ResultFilterDemo
{
    public class CustomResultFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            // Modify the result before it's executed
            if (context.Result is ObjectResult objectResult)
            {
                // Wrap the response object in a custom structure
                objectResult.Value = new
                {
                    Success = true,
                    Data = objectResult.Value,
                    Message = "Operation completed successfully"
                };
            }
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            // Code to run after the result has been executed
        }
    }
}
