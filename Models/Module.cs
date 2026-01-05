using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class Module
    {
        [Key]
        public int idM { get; set; }
        [Required, MaxLength(100)]
        public string LibelleM { get; set; }
        public DateTime DateDebutM { get; set; }
        public DateTime DateFinM { get; set;}
    }
}
