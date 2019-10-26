using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gamercante.Models;

namespace Gamercante.Data
{
    public class GamercanteContext : DbContext
    {
        public GamercanteContext(DbContextOptions<GamercanteContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Gamercante.Models.Game> Game { get; set; }

    }
}
