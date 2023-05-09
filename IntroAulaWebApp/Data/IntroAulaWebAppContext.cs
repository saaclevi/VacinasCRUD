using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IntroAulaWebApp.Models;

namespace IntroAulaWebApp.Data
{
    public class IntroAulaWebAppContext : DbContext
    {
        public IntroAulaWebAppContext (DbContextOptions<IntroAulaWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<IntroAulaWebApp.Models.Aluno> Aluno { get; set; } = default!;

        public DbSet<IntroAulaWebApp.Models.Vacina>? Vacina { get; set; }

        public DbSet<IntroAulaWebApp.Models.Enfermeiro>? Enfermeiro { get; set; }

        public DbSet<IntroAulaWebApp.Models.Setor>? Setor { get; set; }
    }
}
