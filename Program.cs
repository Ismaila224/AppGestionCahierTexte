using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestionCahierTexte.Models;
using AppGestionCahierTexte.Shared;
namespace AppGestionCahierTexte
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			superUser();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexion());
        }

		/// <summary>
		/// creer un user par defaut pour la première utilisation de l'application
		/// </summary>
        public static void  superUser()
        {
			BdCahierTexteContext db = new BdCahierTexteContext();
			string mdp = "passer";
			MD5 md5Hash = MD5.Create();

			string mdpDefaut = Crypto.GetMd5Hash(md5Hash, mdp);
			if (db.ChefDepartement.FirstOrDefault() == null)
			{
				ChefDepartement chefDepartement = new ChefDepartement
				{
					nomU = "admin",
					prenomU = "admin",
					adresseU = "SDF",
					emailU = "admin@gmail.com",
					telephoneU = "782561254",
					identifiantU = "admin",
					motDePasseU = mdpDefaut,

				};
				db.Utilisateur.Add(chefDepartement);
				db.SaveChanges();
			}
			return;
		}
    }
}
