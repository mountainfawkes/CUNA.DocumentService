using System;
using CUNA.DocumentService.Models;

namespace CUNA.DocumentService.Client
{
    public static class DocumentClient
    {
        /*
        
        Ordinarily, I'd take this opportunity to build an HttpClient to build and query
        the third-party service. At the end of this file, I'll provide an example of what 
        that looks like. For this service, I'll simply stub a successful response code.

        */

        public static string ThirdPartyClient(Document payload)
        {
            return "OK";
        }
    }
}
