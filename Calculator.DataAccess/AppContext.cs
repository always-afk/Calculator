using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.DataAccess
{
    public class AppContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-49455G6\\SQLEXPRESS;Database=CalculatorNotes;Trusted_Connection=True");
        }
    }
}
