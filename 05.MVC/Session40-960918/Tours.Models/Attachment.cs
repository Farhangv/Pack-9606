using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    [Table("Attachment", Schema = "Tours")]
    public class Attachment
    {
        [Display(Name = "شناسه")]
        public int Id { get; set; }
        public virtual TourPackage TourPackage { get; set; }
        public int TourPackageId { get; set; }

        public byte[] FileData { get; set; }
        [Display(Name = "نام فایل")]
        public string OriginalFileName { get; set; }
        [Display(Name = "نوع فایل")]
        public string MimeType { get; set; }
        [Display(Name = "سایز فایل")]
        public double FileSize { get; set; }
    }
}
