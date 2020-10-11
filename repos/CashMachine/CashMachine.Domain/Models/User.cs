using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine.Domain.Models
{
    public class User : DomainObject
    {
        //TODO DELete all Id, becauseOf DomainObject,      and Ukr
        // long Id { get; set; }
        public string Name { get; set; }
        //public string NameInUkrainianLanguage { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
