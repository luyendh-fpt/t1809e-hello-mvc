using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HelloCorona.Models
{
    public class MyDatabaseContext: DbContext
    {
        public MyDatabaseContext()
            : base("MyConnectionString")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}