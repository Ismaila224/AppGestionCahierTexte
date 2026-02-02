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
    public partial class frmClasse : Form
    {
        public frmClasse()
        {
            InitializeComponent();
            afficheAnne();
            afficheClasse();
        }
        BdCahierTexteContext db = new BdCahierTexteContext();
        List<Classe> listeClasse = new List<Classe>();
        private void afficheAnne()
        {
            List<AnneeAcademique> listeAnneeAcademique = new List<AnneeAcademique>();
            listeAnneeAcademique = db.AnneeAcademique.ToList();
            listeAnneeAcademique.Insert(0, new AnneeAcademique
            {
                IdAnneeAcademique = 0,
                LibelleAnneeAcademique = "Sélectionner"
            });

            cbbAnneeAcademique.DataSource = listeAnneeAcademique;
            cbbAnneeAcademique.DisplayMember = "LibelleAnneeAcademique";
            cbbAnneeAcademique.ValueMember = "IdAnneeAcademique";
            cbbAnneeAcademique.SelectedIndex = 0;
        }
        private void afficheClasse()
        {
            listeClasse.Clear();
            listeClasse = db.Classe.ToList();
            dgvClasse.DataSource = null;
            dgvClasse.DataSource = listeClasse;
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (cbbAnneeAcademique.SelectedIndex != 0 && cbbAnneeAcademique.SelectedItem != null)
            {
                if (txtLielleClasse.Text != "")
                {
                    AnneeAcademique AnneeAc = cbbAnneeAcademique.SelectedItem as AnneeAcademique;
                    Classe classe = new Classe();
                    classe.LibelleClasse = txtLielleClasse.Text;
                    classe.IdAnneeAcademique = AnneeAc.IdAnneeAcademique;
                    db.Classe.Add(classe);
                    db.SaveChanges();
                    afficheAnne();
                    afficheClasse();
                    cbbAnneeAcademique.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Veuillez saisir le libellé de la classe");
                }

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une année académique");

            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            Classe c = dgvClasse.CurrentRow.DataBoundItem as Classe;
            if (c != null)
            {
                txtLielleClasse.Text = c.LibelleClasse;
                if (c.IdAnneeAcademique != null)
                {
                    cbbAnneeAcademique.SelectedValue = c.IdAnneeAcademique;
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Classe c = dgvClasse.CurrentRow.DataBoundItem as Classe;
            if (c != null)
            {
                db.Classe.Remove(c);
                db.SaveChanges();
                afficheClasse();
                afficheAnne();
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Classe c = dgvClasse.CurrentRow.DataBoundItem as Classe;
            AnneeAcademique aa = cbbAnneeAcademique.SelectedItem as AnneeAcademique;
            if (c != null)
            {
                if (aa != null && cbbAnneeAcademique.SelectedIndex != 0)
                {
                    c.LibelleClasse = txtLielleClasse.Text;
                    c.IdAnneeAcademique = aa.IdAnneeAcademique;
                    db.SaveChanges();
                    afficheClasse();
                    afficheAnne();
                }
                else
                {
                    MessageBox.Show("Selectionner une ligne");
                }
            }
            else
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
