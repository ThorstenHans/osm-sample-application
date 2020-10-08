# Deployment guide for simple app

```bash
# create a namespace
kubectl create namespace osm-simple-app

# assign osm label to onboard namespace
osm namespace add osm-simple-app --enable-sidecar-injection

```
