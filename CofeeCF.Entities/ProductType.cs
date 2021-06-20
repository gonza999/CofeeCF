using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeCF.Entities
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public virtual ICollection<Product> Products { get; set; }=new List<Product>();
    }
}
