using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(1000)]
        public string Contentvalue { get; set; }
        public DateTime ContentDate { get; set; }

        public  bool ContentStatues { get; set; }
        //contentyazar
        //contentbaşlık
        public int HeadingID { get; set; }
        public virtual Heading Heading  { get; set; }

        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
