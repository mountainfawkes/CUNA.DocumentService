using Microsoft.EntityFrameworkCore;
using CUNA.DocumentService.Models;

namespace CUNA.DocumentService
{
    public class DocumentServiceContext : DbContext
    {
        public DocumentServiceContext(DbContextOptions<DocumentServiceContext> options) : base(options) { }

        public DbSet<Document> Documents { get; set; }
    }
}