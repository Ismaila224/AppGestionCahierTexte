using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class syllabus
    {
        [Key]
        public int IdSyllabus { get; set; }
         [Required, MaxLength(100)]
        public string TitreSyllabus { get; set; }
        [Required, MaxLength(100)]
       public int volumeHoraire { get; set; }
        [Required, MaxLength(100)]
       public string niveau { get; set; } 
    }
}
