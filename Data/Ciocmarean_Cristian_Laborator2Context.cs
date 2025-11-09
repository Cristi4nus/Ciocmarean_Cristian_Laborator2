using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciocmarean_Cristian_Laborator2.Models;

namespace Ciocmarean_Cristian_Laborator2.Data
{
    public class Ciocmarean_Cristian_Laborator2Context : DbContext
    {
        public Ciocmarean_Cristian_Laborator2Context (DbContextOptions<Ciocmarean_Cristian_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Ciocmarean_Cristian_Laborator2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ciocmarean_Cristian_Laborator2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Ciocmarean_Cristian_Laborator2.Models.Authors> Authors { get; set; } = default!;
        public DbSet<Ciocmarean_Cristian_Laborator2.Models.Category> Category { get; set; } = default!;
        public DbSet<Ciocmarean_Cristian_Laborator2.Models.Member> Member { get; set; } = default!;
        public DbSet<Ciocmarean_Cristian_Laborator2.Models.Borrowing> Borrowing { get; set; } = default!;
    }
}
