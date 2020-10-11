using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine.Domain.Models
{
    public class Cheque : DomainObject
    {
        public DateTime DateTime { get; set; }
        public StatementOfCheque StatementOfCheque { get; set; }
        public User User { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
