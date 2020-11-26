#!make

DOCKER_REGISTRY_QUALIFIER=thorstenhans

.PHONY: build-docker-images
build-docker-images:
	docker build -t $(DOCKER_REGISTRY_QUALIFIER)/osm-sample-api-v1:0.1.0 -f dockerfiles/api-v1.Dockerfile .
	docker build -t $(DOCKER_REGISTRY_QUALIFIER)/osm-sample-api-v2:0.2.0 -f dockerfiles/api-v2.Dockerfile .
	docker build -t $(DOCKER_REGISTRY_QUALIFIER)/osm-sample-frontend:0.0.1 -f dockerfiles/frontend.Dockerfile .
