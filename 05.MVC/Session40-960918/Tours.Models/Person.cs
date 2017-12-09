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
        [MaxLength(50, ErrorMessage = "نام نباید بیش از ۵۰ کاراکتر باشد")]
        [Column("FirstName"), Required(ErrorMessage = "ورود نام اجباری است")]
        [Display(Name = "نام")]
        public string Name { get; set; }
        [MaxLength(50, ErrorMessage = "نام خانوادگی نباید بیش از ۵۰ کاراکتر باشد"), 
            Column("LastName"), Required(ErrorMessage = "ورود نام خانوادگی اجباری است"),
            Display(Name = "نام خانوادگی")]
        public string Family { get; set; }
        [StringLength(10,ErrorMessage = "کد ملی باید ۱۰ رقم داشته باشد"), 
            RegularExpression(@"^\d{10}$", ErrorMessage = "فرمت کد ملی وارد شده اشتباه است"),
            Display(Name = "کد ملی" )]
        public string NationalCode { get; set; }
        [Timestamp]
        [ScaffoldColumn(false)]
        public byte[] RowVersion { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
