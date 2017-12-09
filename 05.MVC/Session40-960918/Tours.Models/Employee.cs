using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tours.Models.Library;

namespace Tours.Models
{
    [Table("Employee", Schema = "People")]
    public class Employee:Person
    {
        [MaxLength(50), Required, Index(IsUnique = true)]
        public string Username { get; set; }
        [NotMapped, ScaffoldColumn(true)]
        public string Password {
            get {
                return this.PasswordHash;
            }
                set {
                this.PasswordHash = UserHelper.CalculateMD5Hash(value);
            }
        }
        [MaxLength(100), ScaffoldColumn(false)]
        public string PasswordHash { get; set; }
        //public string Role { get; set; }
    }
}
