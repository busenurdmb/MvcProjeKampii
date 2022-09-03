using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Message
    {
        [Key]
        public int MesajId { get; set; }
        [StringLength(50)]
        public string SenderMail { get; set; }
        [StringLength(50)]
        public String RecelverMail { get; set; }
        [StringLength(200)]
        public String Subject { get; set; }
        public String MesajContact { get; set; }
        public bool IsRead { get; set; }

        public DateTime MesajDate { get; set; }
    }
}
