using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(50)]
        public string WriterName { get; set; }
        [StringLength(50)]
        public string writerSurName { get; set; }
        [StringLength(250)]
        public string writerImage { get; set; }
        [StringLength(100)]
        public string writerAbout { get; set; }
        [StringLength(200)]
        public string writerSurMail { get; set; }
        [StringLength(200)]
        public string writerPassword { get; set; }
        [StringLength(50)]
        public string writerTitle{ get; set; }
        public bool WriterSatutes { get; set; }

        public ICollection<Heading> Headings  { get; set; }
        public ICollection<Content> Content { get; set; }




    }
}
