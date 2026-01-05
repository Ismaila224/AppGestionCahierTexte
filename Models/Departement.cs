using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class Departement
    {
        [Key]
        public int IdDep { get; set; }
        [Required, MaxLength(100)]
        public string LibelleDep { get; set; }
    }
}
