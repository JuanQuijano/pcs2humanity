using getsas;
using Xunit;

namespace getsasTest
{
    public class GetSasTest

    {
        [Fact]
        public void GetSas_Do_no_es_empty()
        {
            var sas = new GetSas().Do();

            Assert.NotEmpty(sas);
        }

        [Fact]
        public void GetSas_Do_is_a_SaS()
        {
            var sas = new GetSas().Do();

            Assert.Contains("?sv=", sas);
        }

        [Fact]
        public void GetSas_Do_is_a_Read_and_List_permissions()
        {
            var sas = new GetSas().Do();

            Assert.Contains("&sp=rl", sas);
             
        }
    }
}
