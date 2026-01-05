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

namespace AppGestionCahierTexte.Views.Parametre
{
    public partial class frmDepatement : Form
    {
        public frmDepatement()
        {
            InitializeComponent();
            AfficheDep();
        }
        BdCahierTexteContext db = new BdCahierTexteContext();
        List<Departement> listDep = new List<Departement>();
        private void AfficheDep()
        {
            listDep.Clear();
            listDep = db.Departement.ToList();
            dgvDepartement.DataSource = null;
            dgvDepartement.DataSource = listDep;
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        { 
               if(txtNomDepartement.Text !="")
            {

                Departement dep = new Departement();
                dep.LibelleDep = txtNomDepartement.Text;
                db.Departement.Add(dep);
                db.SaveChanges();
                AfficheDep();
                txtNomDepartement.Text = "";
            }
            else
            {
                MessageBox.Show("Veuillez remplir le champ");
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if(dgvDepartement.CurrentRow != null)
            {
                Departement dep = dgvDepartement.CurrentRow.DataBoundItem as Departement;
                if(dep != null)
                {
                    txtNomDepartement.Text = dep.LibelleDep;
                }
                else
                {
                    MessageBox.Show("Choisir la ligne à selectionner");
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvDepartement.CurrentRow != null)
            {
                Departement dep = dgvDepartement.CurrentRow.DataBoundItem as Departement;
                if (dep != null)
                {
                    if(txtNomDepartement.Text != "")
                    {
                        dep.LibelleDep = txtNomDepartement.Text;
                        db.SaveChanges();
                        AfficheDep();
                        txtNomDepartement.Text = "";
                        txtNomDepartement.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Selectionner la ligne à modifier");
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Departement dep = dgvDepartement.CurrentRow.DataBoundItem as Departement;
            if (dep != null)
            {
                if (txtNomDepartement.Text != "")
                {
                    db.Departement.Remove(dep);
                    db.SaveChanges();
                    AfficheDep();
                    txtNomDepartement.Text = "";
                    txtNomDepartement.Focus();
                }
            }
            else
            {
                MessageBox.Show("Choisir la ligne à supprimer");
            }
        }
    }
}
