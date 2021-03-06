using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace getsas
{
    public static class Images
    {
        [FunctionName("images")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            try
            {
                string responseMessage = new GetSas().Do();
                return new OkObjectResult(responseMessage);
            }
            catch (System.Exception)
            {
                return new NotFoundResult();
            }



        }
    }
}
