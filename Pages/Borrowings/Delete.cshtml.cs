using Ciocmarean_Cristian_Laborator2.Data;
using Ciocmarean_Cristian_Laborator2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ciocmarean_Cristian_Laborator2.Pages.Borrowings
{
    public class DeleteModel : PageModel
    {
        private readonly Ciocmarean_Cristian_Laborator2.Data.Ciocmarean_Cristian_Laborator2Context _context;

        public DeleteModel(Ciocmarean_Cristian_Laborator2.Data.Ciocmarean_Cristian_Laborator2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing
                .Include(b =>b.Book)
                .Include(b =>b.Member)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (borrowing == null)
            {
                return NotFound();
            }
            else
            {
                Borrowing = borrowing;
            }
            ViewData["BookID"] = new SelectList(_context.Book, "ID", "Title");
            ViewData["MemberID"] = new SelectList(_context.Member, "ID", "FullName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.FindAsync(id);
            if (borrowing != null)
            {
                Borrowing = borrowing;
                _context.Borrowing.Remove(Borrowing);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("./Index");
        }
    }
}
