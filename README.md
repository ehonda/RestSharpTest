# RestSharp Playground

This is a small test project consisting of an api and a consumer. To run the consumer, we first need to run the api server, which can be done in the following way when we are in the project root directory:

```bash
cd Api
dotnet run -c Release
```

We can then run the consumer by navigating to the project root directory again and executing:

```bash
cd Consumer
dotnet run -c Release
```