using System;
using CUNA.DocumentService.Models;

namespace CUNA.DocumentService.Client
{
    public class DocumentClient
    {
        /*
        
        Ordinarily, I'd take this opportunity to build an HttpClient to build and query
        the third-party service. At the end of this file, I'll provide an example of what 
        that looks like. For this service, I'll simply stub a successful response code.

        */

        public static string PostDocument(Document payload)
        {
            return "OK";
        }
    }
}

/* 

A more typical client request would have the following characteristics:

- A bearer token, either queried from a configuration endpoint or stored in a web.config file or environment variable
- Static field for the base endpoint (in this case, http://example.com/request)
- Instance invocation of a client; I would use the native HttpClient, but there are many alternatives (Axios is a good example)
- Serialization of the request body, either natively or with a NuGet package like Newtonsoft
- Async invocation of client query with requisite headers, including necessary authorization tokens or keys
- Check for successful response code

For example:

public static class DocumentClient
{
    private static string requestUri = "http://example.com/request";
    private static HttpClient client = new HttpClient();

    public static async Task<HttpResponseMessage> ServiceRequest(Payload payload)
    {
        // serialize the request
        var content = new StringContent(JsonSerializer.Serialize(payload));

        // query the third-party endpoint
        var response = await client.PostAsync(requestUri, content);

        return response;
    }
}

*/
