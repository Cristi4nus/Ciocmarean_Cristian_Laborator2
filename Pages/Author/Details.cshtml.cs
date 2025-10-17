using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciocmarean_Cristian_Laborator2.Data;
using Ciocmarean_Cristian_Laborator2.Models;

namespace Ciocmarean_Cristian_Laborator2.Pages.Author
{
    public class DetailsModel : PageModel
    {
        private readonly Ciocmarean_Cristian_Laborator2.Data.Ciocmarean_Cristian_Laborator2Context _context;

        public DetailsModel(Ciocmarean_Cristian_Laborator2.Data.Ciocmarean_Cristian_Laborator2Context context)
        {
            _context = context;
        }

        public Authors Authors { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
            if (authors == null)
            {
                return NotFound();
            }
            else
            {
                Authors = authors;
            }
            return Page();
        }
    }
}
