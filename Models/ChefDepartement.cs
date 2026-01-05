using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class ChefDepartement : Utilisateur
    {
        public string matriculeCd { get; set; }

        public int? IdDep { get; set; }

        [ForeignKey("IdDep")]
        public virtual  Departement Departement { get; set; }
    }
}
