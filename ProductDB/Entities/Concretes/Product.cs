using ProductDB.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDB.Entities.Concretes
{
    public class Product:BaseEntity
    {
        public string ?Name { get; set; }
        public double ?Price { get; set; }

        public int CategoryId { get; set; }
        public Category ?Category { get; set; }
        public ICollection<ProductOrder>? ProductOrders { get; set; }
    }
}
