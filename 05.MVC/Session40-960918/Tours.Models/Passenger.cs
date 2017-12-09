using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    [Table("Passenger", Schema = "People")]
    public class Passenger:Person
    {
        [StringLength(9, MinimumLength = 9, ErrorMessage = "شماره پاسپورت باید ۹ کاراکتر باشد")]
        [RegularExpression(@"^\w\d{8}$", ErrorMessage = "فرمت شماره پاسپورت اشتباه است")]
        [Required(ErrorMessage = "شماره پاسپورت اجباری است")]
        [Index(IsUnique = true)]
        [Display(Name = "شماره پاسپورت")]
        public string PassportNumber { get; set; }
        [Display(Name = "تاریخ تولد")]
        public DateTime? BirthDate { get; set; }
        public virtual List<TourPackage> TourPackages { get; set; }

        public string PhotoPath { get; set; }
    }
}
