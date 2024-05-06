using ProductDB.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDB.Entities.Concretes
{
    public class ProductOrder:BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Order ?Order { get; set; }
        public Product ?Product { get; set; }
    }
}
