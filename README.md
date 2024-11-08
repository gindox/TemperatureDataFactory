Sample implemenetation of a simple Azure IoT edge module

https://learn.microsoft.com/en-us/azure/iot-edge/tutorial-develop-for-linux?view=iotedge-1.5&tabs=csharp&pivots=iotedge-dev-cli

To build multi-arch containers:

docker buildx build --push --platform linux/arm64/v8,linux/amd64 --tag gindox/temperaturedatafactory .
