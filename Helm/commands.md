helm install nats nats/nats --namespace=nats --create-namespace -f values.yaml

helm uninstall minio --namespace minio

helm upgrade nats nats/nats -n nats -f values.yaml