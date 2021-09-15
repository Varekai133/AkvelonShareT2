using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Task1
{
    class UserContexDDB : DbContext
    {
        public UserContexDDB() : base("DbConnection4") { }

        public DbSet<UserDB> Users { get; set; }
    }
}
