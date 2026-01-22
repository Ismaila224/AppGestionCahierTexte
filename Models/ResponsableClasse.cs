using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class ResponsableClasse : Utilisateur
    {
        [Required, MaxLength(30)]
        public string MatriculeApprenant { get; set; }
        [Required]
        public int? idClasse { get; set; }
        [ForeignKey("idClasse")]
        public virtual Classe Classe { get; set; }
    }
}
