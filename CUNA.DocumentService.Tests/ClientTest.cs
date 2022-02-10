using System;
using Xunit;
using CUNA.DocumentService.Client;
using CUNA.DocumentService.Models;

namespace CUNA.DocumentService.Tests
{
    public class ClientTest
    {
        static public Guid id = Guid.NewGuid();

        static Document payload = new Document
        {
            Body = "This is a sample document",
            Id = id
        };

        [Fact]
        public void ReturnsOK()
        {
            var response = DocumentClient.PostDocument(payload);
            Assert.Equal("OK", response);
        }
    }
}
