# Deployment guide for A/B deployment sample app

```bash
# create a namespace
kubectl create namespace osm-canary-deployment-sample-app

# assign osm label to onboard namespace
kubectl label namespace osm-canary-deployment-sample-app openservicemesh.io/monitored-by=osm

```
