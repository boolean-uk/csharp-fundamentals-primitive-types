using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_primitive_types
{
    internal class E_commerce_order
    {

        public int orderId {  get; set; }

        public string orderName { get; set; }

        public int quantity { get; set; }   

        public decimal full_price { get; set; } 

        public DateTime date { get; set; }

        public string status { get; set; }

    }
}
