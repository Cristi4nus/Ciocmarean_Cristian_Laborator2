using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciocmarean_Cristian_Laborator2.Data;
using Ciocmarean_Cristian_Laborator2.Models;

namespace Ciocmarean_Cristian_Laborator2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Ciocmarean_Cristian_Laborator2.Data.Ciocmarean_Cristian_Laborator2Context _context;

        public IndexModel(Ciocmarean_Cristian_Laborator2.Data.Ciocmarean_Cristian_Laborator2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
        }
    }
}
