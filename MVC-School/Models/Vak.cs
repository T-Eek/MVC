using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace MVC_School.Models
{
    public class Vak
    {
        public int VakId { get; set; }

        [StringLength(20)]
        public string VakNaam { get; set; }

        [ForeignKey("Docent")]
        public int DocentId { get; set; }

        //Dit is de nav property
        public virtual Docent Docent { get; set; }
    }
}
