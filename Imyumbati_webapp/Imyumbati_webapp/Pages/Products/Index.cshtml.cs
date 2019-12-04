using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Imyumbati_webapp.Data;
using Imyumbati_webapp.Models;

namespace Imyumbati_webapp.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly Imyumbati_webapp.Data.ProductContext _context;

        public IndexModel(Imyumbati_webapp.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
