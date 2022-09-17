using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("name=ApplicationDbContext")
        {

        }
        public DbSet<Note> Notes { get; set; }
    }
}
