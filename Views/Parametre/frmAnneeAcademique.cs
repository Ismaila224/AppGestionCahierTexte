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
    public partial class frmAnneeAcademique : Form
    {
        public frmAnneeAcademique()
        {
            InitializeComponent();
            Affichage();
        }
        BdCahierTexteContext db = new BdCahierTexteContext();
        List<AnneeAcademique> listeAnneeAcademique = new List<AnneeAcademique>();
        private void Affichage()
        {
            listeAnneeAcademique.Clear();
            listeAnneeAcademique = db.AnneeAcademique.ToList();
            dgvAnneeAcademique.DataSource = null;
            dgvAnneeAcademique.DataSource = listeAnneeAcademique;

        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(txtLibelleAnneeAcademique.Text != "" && txtValueAnneeAcademique.Text != "")
            {
                AnneeAcademique aa = new AnneeAcademique();
                aa.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
                aa.ValueAnneeAcademique = int.Parse(txtValueAnneeAcademique.Text);
                db.AnneeAcademique.Add(aa);
                db.SaveChanges();
                Affichage();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            AnneeAcademique aa= dgvAnneeAcademique.CurrentRow.DataBoundItem as AnneeAcademique;
            if (aa!=null)
            {
                txtLibelleAnneeAcademique.Text = aa.LibelleAnneeAcademique;
                txtValueAnneeAcademique.Text = aa.ValueAnneeAcademique.ToString();

            }
            else
            {
                MessageBox.Show("ligne non selectionner");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            AnneeAcademique aa = dgvAnneeAcademique.CurrentRow.DataBoundItem as AnneeAcademique;
            if (aa != null)
            {
                aa.LibelleAnneeAcademique = txtLibelleAnneeAcademique.Text;
                aa.ValueAnneeAcademique = int.Parse(txtValueAnneeAcademique.Text);
                db.SaveChanges();
                Affichage();

            }else
            {
                MessageBox.Show("Selectionner une ligne");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            AnneeAcademique aa = dgvAnneeAcademique.CurrentRow.DataBoundItem as AnneeAcademique;
            if (aa != null)
            {
                db.AnneeAcademique.Remove(aa);
                db.SaveChanges();
                Affichage();

            }else
            {
                MessageBox.Show("Selectionner une ligne");
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
