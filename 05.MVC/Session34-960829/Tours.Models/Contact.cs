using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public ContactType ContactType { get; set; }
        public string Value { get; set; }
        public Person Person { get; set; }
    }
}
