using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloCorona.Models
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}