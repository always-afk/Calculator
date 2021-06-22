using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBWorker
{
    class NoteContext : DbContext
    {
        public NoteContext() : base("DbConnection") { }

        public DbSet<Note> Notes { get; set; }
    }
}
