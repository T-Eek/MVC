using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_School.Models
{
    [Table("Locatie")]
    public class Locatie
    {
        public Locatie()
        {
            Docenten = new HashSet<Docent>();
        }
        [Key]
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Naam { get; set; }

        [Required, StringLength(40)]
        public string Adres { get; set; }

        [Required, StringLength(40)]
        public string Woonplaats { get; set; }

        public ICollection<Docent> Docenten { get; set; }
    }
}
