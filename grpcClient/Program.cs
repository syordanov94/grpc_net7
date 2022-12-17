using Grpc.Net.Client;
using System.Threading.Tasks;
using GrpcGreeterClient;

// The port number must match the port of the gRPC server.
GrpcChannelOptions channelOptions = new GrpcChannelOptions();
channelOptions.HttpClient = new HttpClient();
using var channel = GrpcChannel.ForAddress("http://localhost:5002", channelOptions);
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "WorldWithGrpc" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();