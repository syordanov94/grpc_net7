# gRPC Server Communication with both gRPC and REST Clients in .Net7

A gRPC Server written in C# that included the transcoding functionality. This means that this gRPC server can be accesed by both gRPC Client requests as well as simple REST API http client requests. 

The project is divided into 3 parts:

-   The gRPC server implementation. This is included in the /gRPC directory.
-   The gRPC client implementation. This is included in the /grpcClient directory.
-   The HTTP client implementation. This is included in the /httpClient directory.

Each part has to be run indepently depending on which part of the project you want to test.

## Prerequisites

- [.Net 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)


## How to install and Run the project

- First you will have to clone the project from this github repository.

```bash
git clone https://github.com/syordanov94/grpc_net7.git
```

- Once you have cloned the project you will have to start the server.

    - Access the corresponding directory.

    ```
    cd gRPC/
    ```

    - Restore the nugets files that the project uses.

    ```bash
    dotnet restore
    ```

    - Run the server.

    ```bash
    dotnet run
    ```

- Now that the server is innitiatied you can access the client you want to test.

    - For grpc: 

    ```
    cd grpcClient/
    ```

    - For http:

    ```
    cd httpClient/
    ```

    - Once the specific client directory is accessed, all you need to do is restore the nuget packages and run the project.

    ```bash
    dotnet restore
    ```

    ```bash
    dotnet run
    ```