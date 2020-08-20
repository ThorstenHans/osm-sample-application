# Infrastructure as Code - With Terraform

This folder contains a small Terraform project to spin up a simple AKS cluster in an existing Azure Subscription. 

## Requirements

To run the Terraform project, ensure

- Terraform `0.13.0` is installed
- Azure CLI is installed, you're authenticated, and the desired Azure Subscription is selected

```bash
# verify terraform
terraform version

# verify azure cli
az

# login
az login

# select subscription
az account list

az account set --subscription <SUBSCRIPTION_ID>

```

## Deploying the infrastructure

Some basic configuration can be done by adding a new `.tfvars` file or by changing the corresponding values in [default.tfvars](default.tfvars).

```bash
# Initialize the project
terraform init

# Preview and Apply Infrastructure Deployment
terraform apply -var-file default.tfvars

```

## Get AKS cerdentials

Once deployment has finished, verify AKS existence and add the cluster to your `kubectl` contexts.

```bash
# list all aks instances in the resource group
az aks list -g rg-open-service-mesh-sample

# download AKS credentials
az aks get-credentials -n aks-osm-sample -g rg-open-service-mesh-sample

# list kubectl contexts
kubectl config get-contexts

# switch the kubectl context
kubectl config use-context aks-osm-sample

```

## Destroy the infrastructure

You can use Terraform to destroy the infrastructure by invoking:

```bash
terraform destroy -var-file default.tfvars

```