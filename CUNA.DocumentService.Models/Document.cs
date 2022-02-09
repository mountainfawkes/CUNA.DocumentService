using System;

namespace CUNA.DocumentService.Models
{
    public class Document
    {
        public Guid Id { get; set; }
        public string Body { get; set; }
        public string Callback { get; set; }
        public string Detail { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
