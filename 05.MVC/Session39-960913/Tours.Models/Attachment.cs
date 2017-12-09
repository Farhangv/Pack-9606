using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours.Models
{
    [Table("Attachment", Schema = "Tours")]
    public class Attachment
    {
        public int Id { get; set; }
        public virtual TourPackage TourPackage { get; set; }
        public int TourPackageId { get; set; }

        public byte[] FileData { get; set; }
        public string OriginalFileName { get; set; }
        public string MimeType { get; set; }
        public double FileSize { get; set; }
    }
}
