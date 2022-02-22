using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrther.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual  Product Product { get; set; }
        public int NameId { get; set; }
        public virtual User Name { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
