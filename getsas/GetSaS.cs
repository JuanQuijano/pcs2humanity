using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace getsas
{
    public class GetSas
    {
        public string Do()
        {
            var storageAccount = new Connection().Create();
            var blobClient = storageAccount.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("images");

            SharedAccessBlobPolicy adHocPolicy = new SharedAccessBlobPolicy()
            {

                SharedAccessExpiryTime = System.DateTime.UtcNow.AddHours(1),
                Permissions = SharedAccessBlobPermissions.Read | SharedAccessBlobPermissions.List
            };

            var sas = container.GetSharedAccessSignature(adHocPolicy, "image");

            return sas;

        }
    }
}







