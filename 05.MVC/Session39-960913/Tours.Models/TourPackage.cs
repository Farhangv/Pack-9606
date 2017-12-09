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
        [MaxLength(100, ErrorMessage = "حداکثر طول عنوان تور باید ۱۰۰ کاراکتر باشد"), 
            Required(ErrorMessage = "ورود عنوان تور الزامی است"),
            Display(Name = "عنوان تور")]
        public string Title { get; set; }
        [MaxLength(500, ErrorMessage = "توضیحات تور حداکثر باید ۵۰۰ کاراکتر باشد")]
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }

    }
}
