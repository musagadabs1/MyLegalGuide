using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLegalGuide.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int CaseId { get; set; }
        public float FeeStructure { get; set; }
        public decimal TotalAmountDue { get; set; }
        public decimal UnpaidBalance { get; set; }

        public Case Case { get; set; }
    }
}
