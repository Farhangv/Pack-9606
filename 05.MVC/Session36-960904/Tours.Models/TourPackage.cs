using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    [Table("TourPackage", Schema = "Tours")]
    public class TourPackage
    {
        public int Id { get; set; }
        [MaxLength(100), Required]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public virtual List<Passenger> Passengers { get; set; }
    }
}
