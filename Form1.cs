using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestionCahierTexte.Models;
using AppGestionCahierTexte.Shared;
using AppGestionCahierTexte.Views.Utilisateurs;
using Microsoft.VisualBasic.ApplicationServices;

namespace AppGestionCahierTexte
{
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            /*if (verifSaisie())
            {
                var user = this.txtIdentifiant.Text;
                var password = this.txtMostDePasse.Text;
                var pass = "passer123";
                Utilisateur utilisateur = verifConnexion(user, password);
				if (utilisateur != null)
                {
                    
                    if(password == pass)
                    {
                        frmPassword f = new frmPassword();
                        f.utilisateur = utilisateur;
                        f.Show();
                        this.Hide();

                    }
                    else
                    {
                        frmMDI f = new frmMDI();
                        f.profil = this.trouverProfil(utilisateur);
                        f.Show();
                        this.Hide();
                    }
                }
                else { MessageBox.Show("Identifiant ou mot de passe incorrecte");

                    frmMDI f = new frmMDI();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Zone de saisie non remplie");
            }*/

            frmMDI f = new frmMDI();
            f.Show();
            this.Hide();
        }

       /*private string trouverProfil(Utilisateur utilisateur)
        {
            string profil = null;
			BdCahierTexteContext bd = new BdCahierTexteContext();
            if(bd.ResponsableClasse.Where(r => r.IdU == utilisateur.IdU).FirstOrDefault() != null)
            {
                profil = "Responsable";
            }
			/*else if (bd.Professseur.Where(p => p.IdU == utilisateur.IdU).FirstOrDefault() != null ){
                profil = "PROFESSEUR";
            }
            else if (bd.ChefDepartement.Where(p => p.IdU == utilisateur.IdU).FirstOrDefault() != null){
                profil = "ADMIN";
            }
            return profil;

		}
		private Boolean verifSaisie()
        {
            if (string.IsNullOrEmpty(txtIdentifiant.Text) || string.IsNullOrEmpty(txtMostDePasse.Text))
            {
                return false;
            }
            return true;
        }
        private Utilisateur verifConnexion(string user, string password)
        {
            BdCahierTexteContext bd = new BdCahierTexteContext();
            Utilisateur utilisateur = null;
            utilisateur = bd.Utilisateur.Where(u => u.identifiantU == user).FirstOrDefault();
            if (utilisateur != null)
            {
			    MD5 md5Hash = MD5.Create();
                if (Crypto.VerifyMd5Hash(md5Hash, password, utilisateur.motDePasseU))
                {
                    return utilisateur;
                }

            }
            return null;


		}*/
    }
}
