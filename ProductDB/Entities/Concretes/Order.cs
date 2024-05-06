using ProductDB.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDB.Entities.Concretes
{
    public class Order : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<ProductOrder>? ProductOrders { get; set; }

       
    }
}
