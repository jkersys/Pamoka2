using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_044_Estensions.Models
{
    public class Invoice
    {
        public int MyProperty { get; set; }
        public DateTime InvoiceDate { get; set; }
        public BookStorePerson Buyer { get; set; }
        public BookStorePerson Seller { get; set; }
    }
}
