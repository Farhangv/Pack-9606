using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tours.Models
{
    [Table("Person", Schema = "People")]
    public abstract class Person
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Column("FirstName"), Required]
        public string Name { get; set; }
        [MaxLength(50), Column("LastName"), Required]
        public string Family { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
