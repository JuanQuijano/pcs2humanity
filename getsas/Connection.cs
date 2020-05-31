using System.Configuration;
using Microsoft.WindowsAzure.Storage;

namespace getsas
{
    public class Connection
    {
        public CloudStorageAccount Create()
        {
            //REFACTORIZA PARA QUE SE LO TRAIGA DE UN SETTING DEL LOCAL y que luego lo lea del appsetting de la funcion en Azure.
            //Luego que lo traiga de una función.


            //var connectionString = ConfigurationManager.AppSettings["AzureWebJobsStorage"];
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=pcs2hmainstorage;AccountKey=tSM1cp4Z0G1VHmRuKmU0paaNSBWYyI1UufTA8oFDGJNvnG0xAt/8XZmo1bQTbtFHX/upeOiA4HKMSdg8/E8a0w==;EndpointSuffix=core.windows.net";
            var storageAccount = CloudStorageAccount.Parse(connectionString);

            return storageAccount;
        }
    }
}
