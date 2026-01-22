

using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace AppGestionCahierTexte.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BdCahierTexteContext : System.Data.Entity.DbContext
    {
        public BdCahierTexteContext() : base("connCahiertexte")
        {

        }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<AnneeAcademique> AnneeAcademique { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Departement> Departement { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<ChefDepartement> ChefDepartement { get; set; }
        public DbSet<ResponsableClasse> ResponsableClasse { get; set; }

    }
}
