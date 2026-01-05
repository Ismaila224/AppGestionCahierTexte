using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestionCahierTexte.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdCahierTexteContext:DbContext
    {
        public BdCahierTexteContext(): base("connCahiertexte")
        {

        }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<AnneeAcademique> AnneeAcademique {  get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Departement> Departement { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<ChefDepartement> ChefDepartement { get; set; }

    }
}
