#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThePage.Models;

namespace ThePage.Data
{
    public class ThePageContext : DbContext
    {
        public ThePageContext (DbContextOptions<ThePageContext> options)
            : base(options)
        {
        }

        public DbSet<ThePage.Models.Shop> Shop { get; set; }
    }
}
