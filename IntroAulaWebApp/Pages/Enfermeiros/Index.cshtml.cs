using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IntroAulaWebApp.Data;
using IntroAulaWebApp.Models;

namespace IntroAulaWebApp.Pages.Enfermeiros
{
    public class IndexModel : PageModel
    {
        private readonly IntroAulaWebApp.Data.IntroAulaWebAppContext _context;

        public IndexModel(IntroAulaWebApp.Data.IntroAulaWebAppContext context)
        {
            _context = context;
        }

        public IList<Enfermeiro> Enfermeiro { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Enfermeiro != null)
            {
                Enfermeiro = await _context.Enfermeiro.ToListAsync();
            }
        }
    }
}
