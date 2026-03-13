using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class Syllabus
    {
        [Key]
        public int IdSyllabus { get; set; }
        [Required, MaxLength(100)]
        public string Libelle { get; set; }

        public int? IdMatiere { get; set; }

        [ForeignKey("IdMatiere")]
        public virtual Matiere Matiere { get; set; }

        public int? idClasse { get; set; }

        [ForeignKey("idClasse")]
        public virtual Classe Classe { get; set; }
        [Required, MaxLength(100)]
        public string Description { get; set; }
        

    }
}
