using Microsoft.Extensions.Logging;
using getsas;
using Xunit;

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
    }
}


//var result = response as OkObjectResult;
//Assert.Contains("&sp=rl", result.Value.ToString()); ;
