using Newtonsoft.Json;
using System;
using Xunit;
using CUNA.DocumentService.Client;
using CUNA.DocumentService.Models;
using CUNA.DocumentService.Controllers;

namespace CUNA.DocumentService.Tests
{
	public class DocumentControllerTest
	{
		private DocumentController _controller;
		public static Guid id = Guid.NewGuid();
		public static string body = "document body";

		[Fact]
		public async void ReturnsDocumentPayload()
		{
			string payload = JsonConvert.SerializeObject(new Document() { Body = body });
			var response = await _controller.Post(body);
			string result = JsonConvert.SerializeObject(response);
			Assert.Equal(payload, result);
		}
	}
}