using ProductDB.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDB.Entities.Concretes
{
    public class Category:BaseEntity
    {
        public string ?Name { get; set; }
        public ICollection<Product> ?Products { get; set; }
    }
}
