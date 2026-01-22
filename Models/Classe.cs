using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class Classe
    {
        [Key]
        public int idClasse { get; set; }
        [Index(nameof(LibelleClasse),IsUnique = true)]
        [Required, MaxLength(20)]
        public String LibelleClasse { get; set; }
        public int? IdAnneeAcademique { get; set; }

        [ForeignKey("IdAnneeAcademique")]
        public virtual AnneeAcademique AnneeAcademique { get; set; }


    }
}
