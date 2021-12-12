using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ardelean_Adelin_Lab8.Modes;

namespace Ardelean_Adelin_Lab8.Data
{
    public class Ardelean_Adelin_Lab8Context : DbContext
    {
        public Ardelean_Adelin_Lab8Context (DbContextOptions<Ardelean_Adelin_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ardelean_Adelin_Lab8.Modes.Book> Book { get; set; }

        public DbSet<Ardelean_Adelin_Lab8.Modes.Publisher> Publisher { get; set; }
    }
}
