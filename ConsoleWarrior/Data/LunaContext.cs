using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsoleWarrior.Models;

namespace ConsoleWarrior.Data
{
    internal class LunaContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\.; Initial Catalog = Luna; Integrated Security = True; Pooling = False");
        }
    }
    
}
