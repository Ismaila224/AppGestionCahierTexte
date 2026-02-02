using AppGestionCahierTexte.Models;
using AppGestionCahierTexte.Shared;
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

namespace AppGestionCahierTexte.Views.Utilisateurs
{
    public partial class frmPassword : Form
    {
        public BdCahierTexteContext db = new BdCahierTexteContext();
        public Utilisateur utilisateur;
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string trouverProfil(Utilisateur utilisateur)
        {
            string profil = null;
            BdCahierTexteContext bd = new BdCahierTexteContext();
            if (bd.ResponsableClasse.Where(r => r.IdU == utilisateur.IdU).FirstOrDefault() != null)
            {
                profil = "ADMIN";
            }
            /*else if (bd.Professseur.Where(p => p.IdU == utilisateur.IdU).FirstOrDefault() != null ){
                profil = "PROFESSEUR";
            }*/
            else if (bd.ChefDepartement.Where(p => p.IdU == utilisateur.IdU).FirstOrDefault() != null){
                profil = "ADMIN";
            }
            return profil;

        }

        private void btnNouveauPassword_Click(object sender, EventArgs e)
        {
            if(txtNouveauPassword.Text == "")
            {
                MessageBox.Show("Les mots de passe ne correspondent pas.");
                return;
            }
            else
            {
                if(txtNouveauPassword.Text == "passer123")
                {
                    MessageBox.Show("Le nouveau mot de passe ne peut pas être le mot de passe par défaut.");

                }
                else {
                    string mdp = txtNouveauPassword.Text;
                    MD5 md5Hash = MD5.Create();

                    string mdpDefaut = Crypto.GetMd5Hash(md5Hash, mdp);
                    db.Utilisateur.Where(u => u.IdU == utilisateur.IdU).FirstOrDefault().motDePasseU = mdpDefaut;
                    db.SaveChanges();
                    MessageBox.Show("Mot de passe modifié avec succès.");
                    frmMDI f = new frmMDI();
                    f.profil = this.trouverProfil(utilisateur);
                    f.Show();
                    this.Hide();
                }
            }
               
        }
    }
}
