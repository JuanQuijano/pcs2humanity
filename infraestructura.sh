az group create --location westeurope -n "borrame1"
az storage account create -g borrame1 -l westeurope -n borrame1sg --sku Standard_LRS --kind StorageV2
