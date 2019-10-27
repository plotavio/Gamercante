using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gamercante.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Gamercante.Data
{
    public class GamercanteContext : IdentityDbContext
    {
        public GamercanteContext(DbContextOptions<GamercanteContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Gamercante.Models.Game> Game { get; set; }

    }
}
