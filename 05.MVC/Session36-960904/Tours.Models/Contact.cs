using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    [Table("Contact", Schema = "People")]
    public class Contact
    {
        //[Key]
        public int Id { get; set; }
        public ContactType ContactType { get; set; }
        [Required, Index(IsUnique = true), MaxLength(50)]
        public string Value { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
