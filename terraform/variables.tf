variable "custom_tags" {
  type        = map
  default     = {}
  description = "custom tags associated with the Azure resources"
}

variable "location" {
  type        = string
  default     = "westeurope"
  description = "Azure Region: find suitable regions using az account list-locations"
}

variable "aks_worker_node_count" {
  type        = number
  default     = 2
  description = "specify the number of AKS worker nodes"
}