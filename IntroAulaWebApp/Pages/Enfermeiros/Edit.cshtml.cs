using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IntroAulaWebApp.Data;
using IntroAulaWebApp.Models;

namespace IntroAulaWebApp.Pages.Enfermeiros
{
    public class EditModel : PageModel
    {
        private readonly IntroAulaWebApp.Data.IntroAulaWebAppContext _context;

        public EditModel(IntroAulaWebApp.Data.IntroAulaWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Enfermeiro Enfermeiro { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Enfermeiro == null)
            {
                return NotFound();
            }

            var enfermeiro =  await _context.Enfermeiro.FirstOrDefaultAsync(m => m.Id == id);
            if (enfermeiro == null)
            {
                return NotFound();
            }
            Enfermeiro = enfermeiro;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Enfermeiro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnfermeiroExists(Enfermeiro.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EnfermeiroExists(int id)
        {
          return (_context.Enfermeiro?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
