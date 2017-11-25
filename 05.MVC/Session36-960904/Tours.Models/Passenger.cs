using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    [Table("Passenger", Schema = "People")]
    public class Passenger:Person
    {
        public string PassportNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public virtual List<TourPackage> TourPackages { get; set; }
    }
}
