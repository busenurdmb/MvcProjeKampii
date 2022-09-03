using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skiil
    {
        [Key]
        public int SkillID { get; set; }
        [StringLength(50)]
        public string SkillName { get; set; }
        [StringLength(50)]
        public string Skillvalues { get; set; }

        public int add { get; set; }
    }
}
