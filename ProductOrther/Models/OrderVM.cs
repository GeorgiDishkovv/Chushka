using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrther.Data
{
    public class OrderVM
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual  ProductVM Product { get; set; }
        public int NameId { get; set; }
        public virtual UserVM Name { get; set; }
        public DateTime OrderedOn { get; set; }
    }
}
