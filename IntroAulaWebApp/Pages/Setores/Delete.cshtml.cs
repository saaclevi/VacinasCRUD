using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IntroAulaWebApp.Data;
using IntroAulaWebApp.Models;

namespace IntroAulaWebApp.Pages.Setores
{
    public class DeleteModel : PageModel
    {
        private readonly IntroAulaWebApp.Data.IntroAulaWebAppContext _context;

        public DeleteModel(IntroAulaWebApp.Data.IntroAulaWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Setor Setor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Setor == null)
            {
                return NotFound();
            }

            var setor = await _context.Setor.FirstOrDefaultAsync(m => m.Id == id);

            if (setor == null)
            {
                return NotFound();
            }
            else 
            {
                Setor = setor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Setor == null)
            {
                return NotFound();
            }
            var setor = await _context.Setor.FindAsync(id);

            if (setor != null)
            {
                Setor = setor;
                _context.Setor.Remove(Setor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
