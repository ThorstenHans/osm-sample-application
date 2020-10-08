# Ingress Deployment

The NGINX Ingress deployment is optional. However, if an Ingress is deployed to your cluster, you can expose both samples by deploying the corresponding `ingress.yml` located in both sample sub-folders.

## Running without Ingress

If you want to use the samples without an Ingress deployment, you have to use port-forwarding and point to the corresponding frontend pod of each sample application.

## Requirements

The [deploy-ingress.sh](deploy-ingress.sh) script requires [Helm CLI](https://helm.sh) to be installed on your system.
