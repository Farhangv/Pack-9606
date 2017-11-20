using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    public class Passenger:Person
    {
        public string PassportNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public List<TourPackage> TourPackages { get; set; }
    }
}
