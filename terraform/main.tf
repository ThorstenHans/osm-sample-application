terraform {
    required_version = "=0.13.0"
}
provider "azurerm" { 
    features {}
    version = "=2.23.0"
     }

locals {
  default_tags = { app = "Open Service Mesh Demo" }
  tags         = merge(local.default_tags, var.custom_tags)
}

resource "azurerm_resource_group" "rg" {
  name     = "rg-open-service-mesh-sample"
  location = var.location
  tags     = local.tags
}

resource "azurerm_kubernetes_cluster" "aks" {
  name                = "aks-osm-sample"
  resource_group_name = azurerm_resource_group.rg.name
  location            = var.location
  dns_prefix          = "aks-osm"
  tags                = local.tags

  default_node_pool {
    name       = "default"
    node_count = 2
    vm_size    = "Standard_D2_v2"
  }

  identity {
    type = "SystemAssigned"
  }
}