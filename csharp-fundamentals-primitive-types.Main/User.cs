using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_primitive_types
{
    internal class User
    {
        public string user_name {  get; set; }

        
        public string password { get; set; }    

        public int phone_number { get; set; }    

        public string email { get; set; }   

        public string address { get; set; }

        public bool uses_two_factor_authentication { get; set; }

        public char membership_type {  get; set; }
    }
}
