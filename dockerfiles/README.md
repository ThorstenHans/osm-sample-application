# Open Service Mesh Sample - Dockerfiles

This folder contains default .NET core dockerfiles, to build the images invoke the corresponding `make` command from within repository root folder:

```bash
# ensure you're in the repo root folder
make build-docker-images

```

For demonstration purpose, images are published to public Docker Hub. However, nothing stops you from pushing those images to a protected Docker registry like Azure Container Registry for example.