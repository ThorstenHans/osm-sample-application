# Deployment guide for A/B deployment sample app

```bash
# create a namespace
kubectl create namespace osm-canary-deployment-sample-app

# assign osm annotation to onboard namespace
kubectl annotate namespace osm-canary-deployment-sample-app openservicemesh.io/monitored-by=osm

```
