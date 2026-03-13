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
    public partial class frmProfesseur : Form
    {
        public frmProfesseur()
        {
            InitializeComponent();
            affichage();
        }
        BdCahierTexteContext db = new BdCahierTexteContext();

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string mdp = "passer123";
            MD5 md5Hash = MD5.Create();

            string mdpDefaut = Crypto.GetMd5Hash(md5Hash, mdp);
            Professeur professeur = new Professeur
            {
                nomU = txtNom.Text,
                prenomU = txtPrenom.Text,
                adresseU = txtAdresse.Text,
                emailU = txtEmail.Text,
                telephoneU = txtTel.Text,
                identifiantU = txtIdentifiant.Text,
                motDePasseU = mdpDefaut,
                specialiteProf = txtSpecialite.Text
            };
            db.Professeur.Add(professeur);
            db.SaveChanges();
            MessageBox.Show("Professeur ajouté avec succès !");
            clear();
            affichage();
        }

        private void clear()
        {
            this.txtNom.Clear();
            this.txtPrenom.Clear();
            this.txtTel.Clear();
            this.txtEmail.Clear();
            this.txtIdentifiant.Clear();
            this.txtAdresse.Clear();
            this.txtSpecialite.Clear();
            this.txtIdentifiant.Clear();

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvProfesseur.CurrentRow != null)
            {
                Professeur professeur = dgvProfesseur.CurrentRow.DataBoundItem as Professeur;
                if (professeur != null)
                {
                    db.Professeur.Remove(professeur);
                    db.SaveChanges();
                    MessageBox.Show("Professeur supprimé avec succès !");
                    clear();
                    affichage() ;
                }
                else
                {
                    MessageBox.Show("Aucune ligne selectionner");
                }
            }
            else
            {
                MessageBox.Show("Choisir la ligne à supprimer");
            }

        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            Professeur professeur = dgvProfesseur.CurrentRow.DataBoundItem as Professeur;
            if (professeur != null)
            {
                txtNom.Text = professeur.nomU;
                txtPrenom.Text = professeur.prenomU;
                txtAdresse.Text = professeur.adresseU;
                txtEmail.Text = professeur.emailU;
                txtTel.Text = professeur.telephoneU;
                txtIdentifiant.Text = professeur.identifiantU;
                txtSpecialite.Text = professeur.specialiteProf;
            }

        }

        public void affichage()
        {
            dgvProfesseur.DataSource = null;
            dgvProfesseur.DataSource = db.Professeur.ToList();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Professeur professeur = dgvProfesseur.CurrentRow.DataBoundItem as Professeur;
            if (professeur != null)
            {
                professeur.nomU = txtNom.Text;
                professeur.prenomU = txtPrenom.Text;
                professeur.adresseU = txtAdresse.Text;
                professeur.emailU = txtEmail.Text;
                professeur.telephoneU = txtTel.Text;
                professeur.identifiantU = txtIdentifiant.Text;
                professeur.specialiteProf = txtSpecialite.Text;

                db.SaveChanges();
                clear();
                affichage();
            }
        }
    }
}
