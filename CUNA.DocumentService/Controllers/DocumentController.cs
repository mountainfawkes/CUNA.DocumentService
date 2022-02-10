using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CUNA.DocumentService.Models;
using CUNA.DocumentService.Client;

namespace CUNA.DocumentService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly DocumentServiceContext _db;
        private readonly DocumentClient _client;
        
        public DocumentController(DocumentServiceContext db)
        {
            _db = db;
        }

        // Post a request
        [Route("/request")]
        [HttpPost]
        public async Task<ActionResult<string>> Post(string body)
        {
            Document payload = new() { Body = body };
            var response = _client.PostDocument(payload);
            return CreatedAtAction("Post", "");
        }

        // // Post a callback
        // [Route("/callback")]
        // [HttpPost]
        // public async Task<ActionResult<Document>> Post(Guid id)
        // {
        // }

        // // Callback to update status
        // [Route("/callback/{id}")]
        // [HttpPut]
        // public async Task<ActionResult<Document>> Put()
        // {
        // }

        // // Callback to get status
        // [Route("/callback/{id}")]
        // [HttpGet]
        // public async Task<ActionResult<Document>> Get()
        // {
        // }
    }
}
