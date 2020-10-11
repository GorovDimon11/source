using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine.Domain.Models
{
    public class Record : DomainObject
    {
        public DateTime DateTime { get; set; }
        public IEnumerable<Cheque> Cheques { get; set; }
        public TypeOfRecord TypeOfRecord { get; set; }
        public User User { get; set; }
    }
}
