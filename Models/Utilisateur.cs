using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class Utilisateur
    {
        [Key]
        public int IdU { get; set; }
        [Required, MaxLength(100)]
        public string nomU { get; set; }
        [Required, MaxLength(100)]
        public string prenomU { get; set; }
        [Required, MaxLength(100)]
        public string adresseU { get; set; }
        [Required, MaxLength(100)]
        public string emailU { get; set; }
        [Required, MaxLength(15)]
        public string telephoneU { get; set; }
        [Required, MaxLength(100)]
        public string identifiantU { get; set; }
        [Required, MaxLength(100)]
        public string motDePasseU { get; set; }

    }
}
