using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using getsas;
using Xunit;

namespace getsasTest
{
    public class ImagesTest
    {

        private readonly ILogger logger = TestFactory.CreateLogger();

        [Fact]
        public async void Images_devuelve_una_sas_de_lectura_y_listado()
        {
            var request = TestFactory.CreateHttpRequest("", "");
            var response = await Images.Run(request, logger);
            var result = response as OkObjectResult;

            Assert.Contains("&sp=rl", result.Value.ToString()); ;
        }
    }
}
