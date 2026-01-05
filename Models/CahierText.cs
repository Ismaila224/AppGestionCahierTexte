using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    public class CahierText
    {
        public int IdCahier { get; set; }
        public string TitreCahier { get; set; }
        public string DescriptionCahier { get; set; }
        public int AnneeAcademiqueId { get; set; }
       
    }
}
