using AppGestionCahierTexte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionCahierTexte.Views.Utilisateurs
{
    public partial class frmChefDepartement : Form
    {
        public frmChefDepartement()
        {
            InitializeComponent();
            AfficheChefDep();
            AfficheDep();
        }
        BdCahierTexteContext db = new BdCahierTexteContext();
        List<ChefDepartement> listeChefDep = new List<ChefDepartement>();

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AfficheChefDep()
        {
            listeChefDep.Clear();
            listeChefDep = db.ChefDepartement.ToList();
            dgvChefDepartement.DataSource = null;
            dgvChefDepartement.DataSource = listeChefDep;
        }
        private void AfficheDep()
        {
            List<Departement> listeDep = new List<Departement>();
            listeDep = db.Departement.ToList();
            listeDep.Insert(0, new Departement
            {
                IdDep = 0,
                LibelleDep = "Sélectionner"
            });
            cbbDepartementId.DataSource = listeDep;
            cbbDepartementId.DisplayMember = "LibelleDep";
            cbbDepartementId.ValueMember = "IdDep";
            cbbDepartementId.SelectedIndex = 0;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (cbbDepartementId.SelectedIndex == 0)
            {
                MessageBox.Show("Veuillez sélectionner un département.");
            }
            else
            {
                if(txtAdresse.Text=="" || txtEmail.Text=="" || txtNom.Text=="" || txtPrenom.Text=="")
                {
                    MessageBox.Show("Veuillez remplir tous les champs.");
                }
                else
                {
                    Departement dep = cbbDepartementId.SelectedItem as Departement;
                    ChefDepartement chfD = new ChefDepartement();
                    chfD.nomU = txtNom.Text;
                    chfD.prenomV = txtPrenom.Text;
                    chfD.adresseU = txtAdresse.Text;
                    chfD.emailU = txtEmail.Text;
                    chfD.matriculeCd = txtNom.Text + txtPrenom.Text + chfD.IdU;
                    chfD.IdDep = dep.IdDep;
                    db.ChefDepartement.Add(chfD);
                    db.SaveChanges();
                    AfficheDep();
                    AfficheChefDep();
                    cbbDepartementId.SelectedIndex = 0;
                    txtNom.Text = "";
                    txtPrenom.Text = "";
                    txtAdresse.Text = "";
                    txtEmail.Text = "";
                    txtNom.Focus();
                }
            }
            

        }

       
    }
}
