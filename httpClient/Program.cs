// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using restClient;

HttpClient client = null;

try
{
    // --- (1) ----
    // Build client settings
    client = new HttpClient
    {
        DefaultRequestVersion = HttpVersion.Version20,
        DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact
        
    };
    
    // --- (2) ----
    // Call the service
    HttpResponseMessage resp = await client.GetAsync("http://localhost:5002/v1/greeter/WorldWithREST");
    resp.EnsureSuccessStatusCode();  
}
catch(Exception ex)
{
    Console.Write(ex.ToString());
}
finally
{
    if (client != null)
    {
        client.Dispose();
        client = null;
    }
}

