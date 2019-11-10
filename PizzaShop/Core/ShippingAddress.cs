using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaShop.Core
{
    public class ShippingAddress
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Line1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
