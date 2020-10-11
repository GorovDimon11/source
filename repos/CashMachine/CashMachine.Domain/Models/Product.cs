using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine.Domain.Models
{
    public class Product : DomainObject
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
