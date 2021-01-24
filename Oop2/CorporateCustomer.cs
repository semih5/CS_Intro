using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
    }
}
