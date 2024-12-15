using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualArt.Models;

namespace VisualArt.Data
{
    public class VisualArtContext : DbContext
    {
        public VisualArtContext (DbContextOptions<VisualArtContext> options)
            : base(options)
        {
        }

        public DbSet<VisualArt.Models.Art> Art { get; set; } = default!;
    }
}
