using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Task1
{
    class PasswordContexDB1 : DbContext
    {
        public PasswordContexDB1() : base("DbConnection7") { }

        public DbSet<PasswordDDB1> Passwords { get; set; }
    }
}
