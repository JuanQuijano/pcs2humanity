using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using getsas;
using Xunit;

namespace getsasTest
{
    public class ConnectionTest
    {

        [Fact]
        public void Create_connection_to_Storage_Account_Is_NOT_NULL()
        {
            var connection = new Connection();

            var response = connection.Create();
            
            Assert.NotNull(response);
        }
    }
}
