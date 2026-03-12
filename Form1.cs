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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;



namespace AppGestionCahierTexte
{
    public partial class frmConnexion : Form
    {
        private readonly ILogger<frmConnexion> _logger;
        public frmConnexion()
        {
            InitializeComponent();
            _logger = LogClasse.ServiceProvider.GetService<ILogger<frmConnexion>>();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
            _logger.LogInformation("Application quittée par l'utilisateur");
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            if (verifSaisie())
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
                        _logger.LogInformation("Utilisateur {User} connecté avec succès, mot de passe par défaut utilisé", user);
                        LogClasse.Info("Ttentative de connexion","Utilisateur  "+user+" connecté avec succès, mot de passe par défaut utilisé");

                    }
                    else
                    {
                        frmMDI f = new frmMDI();
                        f.profil = this.trouverProfil(utilisateur);
                        f.Show();
                        this.Hide();
                        _logger.LogInformation("Utilisateur {User} connecté avec succès", user);
                        LogClasse.Info("Ttentative de connexion", "Utilisateur  " + user + " connecté avec succès");

                    }
                }
                else { 
                    MessageBox.Show("Identifiant ou mot de passe incorrecte");
                    _logger.LogWarning("Tentative de connexion échouée pour l'utilisateur {User}", user);
                    LogClasse.Warning("Ttentative de connexion", "Tentative de connexion échouée pour l'utilisateur  " + user);
                    mail.sendEmail();
                }
            }
            else
            {
                MessageBox.Show("Zone de saisie non remplie");
            }

        }


        private string trouverProfil(Utilisateur utilisateur)
         {
             string profil = null;
             BdCahierTexteContext bd = new BdCahierTexteContext();
             if(bd.ResponsableClasse.Where(r => r.IdU == utilisateur.IdU).FirstOrDefault() != null)
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


         }
    }
}
