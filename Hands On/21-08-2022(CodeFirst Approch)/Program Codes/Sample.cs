using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EFcfa
{
    [Table("SampleTbl")]
    public class Sample
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public long MobileNo { get; set; }

    }
}
