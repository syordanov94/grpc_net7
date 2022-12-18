# gRPC Server Communication with both gRPC and REST Clients in .Net7

A gRPC Server written in C# that included the transcoding functionality. This means that this gRPC server can be accesed by both gRPC Client requests as well as simple REST API http client requests. 

The project is divided into 3 parts:

-   The gRPC server implementation. This is included in the /gRPC directory.
-   The gRPC client implementation. This is included in the /grpcClient directory.
-   The HTTP client implementation. This is included in the /httpClient directory.

Each part has to be run indepently depending on which part of the project you want to test.


