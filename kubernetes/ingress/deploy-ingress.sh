#!/bin/bash

helm repo add https://kubernetes.github.io/ingress-nginx
helm repo update

helm install ingress ingress-nginx/ingress-nginx --namespace ingress
