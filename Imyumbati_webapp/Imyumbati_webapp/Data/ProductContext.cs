using Microsoft.EntityFrameworkCore;

namespace Imyumbati_webapp.Data
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Models.Product> Products { get;set;}
    }
}