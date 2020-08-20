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