using Microsoft.Extensions.Logging;
using getsas;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace getsasTest
{
    public class ImagesTest
    {

        private readonly ILogger logger = TestFactory.CreateLogger();

        [Fact]
        public async void Images_devuelve_no_devuelve_null()
        {
            var request = TestFactory.CreateHttpRequest("", "");
            var response = await Images.Run(request, logger);
            
            Assert.NotNull(response);
            
        }

        [Fact]
        public async void Images_devuelve_una_SaS_con_permisos_de_lectura_y_listado()
        {
            var request = TestFactory.CreateHttpRequest("", "");
            var response = await Images.Run(request, logger);

            var result = response as OkObjectResult;

            Assert.Contains("?sv=", result.Value.ToString()); ;
            Assert.Contains("&sp=rl", result.Value.ToString()); ;
        }
    }
}



