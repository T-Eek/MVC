using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MVC_School.Data
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required, StringLength(20)]
        public string StudentVName { get; set; }

        [Required, StringLength(40)]
        public string StudentAName { get; set; }

        [Required, StringLength(40)]
        public string Adres { get; set; }

        [Required, StringLength(40)]
        public string Woonplaats { get; set; }
    }
}
