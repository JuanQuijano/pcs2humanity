az group create --location westeurope -n borrame1
az storage account create -g borrame1 -l westeurope -n borrame1sg --sku Standard_LRS --kind StorageV2
az functionapp create --consumption-plan-location westeurope --name borramefunction --os-type Windows --resource-group borrame1 --runtime dotnet --storage-account borrame1sg
az storage account keys list -g borrame1 -n borrame1sg
