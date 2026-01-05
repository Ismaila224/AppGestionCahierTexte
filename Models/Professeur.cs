using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class Professeur: Utilisateur
    {
        [Required, MaxLength(100)]
        public string specialiteProf { get; set; }


    }
}
