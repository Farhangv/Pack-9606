using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    [Table("Employee", Schema = "People")]
    public class Employee:Person
    {
        [MaxLength(50), Required, Index(IsUnique = true)]
        public string Username { get; set; }
        [NotMapped]
        public string Password { get; set; }
        [MaxLength(100)]
        public string PasswordHash { get; set; }
    }
}
