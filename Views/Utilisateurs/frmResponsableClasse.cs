using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AppGestionCahierTexte.Models;
using AppGestionCahierTexte.Shared ;
using System.Data.Entity;


namespace AppGestionCahierTexte.Views.Utilisateurs
{
    public partial class frmResponsableClasse : Form
    {
        public frmResponsableClasse()
        {
            InitializeComponent();
			affichage();
		}
		List<ResponsableClasse> responsables = new List<ResponsableClasse>();
         BdCahierTexteContext db = new BdCahierTexteContext();
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string mdp = "passer123";
            MD5 md5Hash = MD5.Create() ;

			string mdpDefaut = Crypto.GetMd5Hash(md5Hash,mdp);

			if (verifSaisie())
            {
                ResponsableClasse responsable = new ResponsableClasse
                {
                    nomU = txtNom.Text,
                    prenomU = txtPrenom.Text,
                    adresseU = txtAdresse.Text,
                    emailU = txtEmail.Text,
                    telephoneU = txtTel.Text,
                    identifiantU = txtIdentifiant.Text,
                    motDePasseU = mdpDefaut,
                    MatriculeApprenant = txtMat.Text,
                    idClasse = int.Parse(txtNomClasse.Text)

                };
                db.ResponsableClasse.Add(responsable);
                db.SaveChanges();
                clear();
				affichage();
			}
		}



        public void clear()
        {
            this.txtNom.Text = string.Empty;
            this.txtPrenom.Text = string.Empty;
            this.txtAdresse.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtTel.Text = string.Empty;
            this.txtIdentifiant.Text = string.Empty;
            this.txtMat.Text = string.Empty;
            this.txtNomClasse.Text = string.Empty;
        }
        public void affichage()
        {
            responsables.Clear();
            var responsablesClassses = db.ResponsableClasse.Include(r => r.Classe)
                .Select(r => new{
                    r.nomU,
                    r.prenomU,
                    r.adresseU,
                    r.emailU,
                    r.telephoneU,
                    r.identifiantU,
                    classe = r.Classe.LibelleClasse
                }).ToList() ;
            if (responsablesClassses.Count > 0)
            {
                this.dgvResponsable.DataSource = null;
                this.dgvResponsable.DataSource = responsablesClassses;
            }
		}

        public Boolean verifSaisie()
        {
            
            return !(string.IsNullOrEmpty(txtNom.Text)) ||
					!(string.IsNullOrEmpty(txtPrenom.Text)) ||
					!(string.IsNullOrEmpty(txtAdresse.Text)) ||
					!(string.IsNullOrEmpty(txtEmail.Text)) ||
					!(string.IsNullOrEmpty(txtTel.Text)) ||
					!(string.IsNullOrEmpty(txtIdentifiant.Text)) ||
					!(string.IsNullOrEmpty(txtMat.Text))
				;
		}
    }
}
