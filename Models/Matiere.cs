using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class Matiere
    {
        [Key]
        public int IdMatiere { get; set; }
        [Required, MaxLength(200)]
        public string libelleMatiere { get; set; }
        [Required]
        public int? VolumeHoraireMatiere { get; set; }
        [Required, MinLength(80)]
        public String niveau { get; set; }
    }
}
