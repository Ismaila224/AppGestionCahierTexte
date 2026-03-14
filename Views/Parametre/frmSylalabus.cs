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
    public partial class frmSylalabus : Form
    {
        private object db;

        public frmSylalabus()
        {
            InitializeComponent();
            affichagecbb();
            affichage();
        }


        private void affichagecbb()
        {   BdCahierTexteContext db = new BdCahierTexteContext();
            List<Matiere> matieres = db.Matieres.ToList();
            matieres.Insert(0, new Matiere { IdMatiere = 0, libelleMatiere = "Sélectionner une matière" });
            List<Classe> classes = db.Classe.ToList();
            classes.Insert(0, new Classe { idClasse = 0, LibelleClasse = "Sélectionner une classe" });
            cbbMatieres.DataSource = matieres;
            cbbMatieres.DisplayMember = "libelleMatiere";
            cbbMatieres.ValueMember = "idMatiere";
            cbbClasse.DataSource = classes;
            cbbClasse.DisplayMember = "LibelleClasse";
            cbbClasse.ValueMember = "idClasse";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Syllabus syllabus = new Syllabus();
            syllabus = dgvSyllabus.CurrentRow.DataBoundItem as Syllabus;
            BdCahierTexteContext db = new BdCahierTexteContext();
            if (syllabus != null)
            {
                    db.Syllabus.Remove(syllabus);
                    db.SaveChanges();
                    MessageBox.Show("Syllabus supprimé avec succès.");
                    affichage();
                    affichagecbb();
            }
        }

        private void affichage()
        {
            BdCahierTexteContext db = new BdCahierTexteContext();
            List<Syllabus> syllabus = db.Syllabus.ToList();
            dgvSyllabus.DataSource  = null;
            dgvSyllabus.DataSource = syllabus;
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Syllabus syllabus = new Syllabus();
            syllabus = dgvSyllabus.CurrentRow.DataBoundItem as Syllabus;
            if (syllabus != null)
            {
                BdCahierTexteContext bd = new BdCahierTexteContext();
                syllabus.Libelle = txtLibelle.Text;
                syllabus.Description = txtDescription.Text;
                syllabus.IdMatiere = int.Parse(cbbMatieres.SelectedValue.ToString());
                syllabus.idClasse = int.Parse(cbbClasse.SelectedValue.ToString());

                affichage();
                affichagecbb();
                MessageBox.Show("Syllabus modifié avec succès.");
            }
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            Syllabus syllabus = new Syllabus();
            syllabus = dgvSyllabus.CurrentRow.DataBoundItem as Syllabus;
            if (syllabus != null)
            {
                txtLibelle.Text = syllabus.Libelle;
                txtDescription.Text = syllabus.Description;
                cbbMatieres.SelectedValue = syllabus.IdMatiere;
                cbbClasse.SelectedValue = syllabus.idClasse;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            BdCahierTexteContext db = new BdCahierTexteContext();

            Syllabus syllabus = new Syllabus();
            syllabus.Libelle = txtLibelle.Text;
            syllabus.Description = txtDescription.Text;
            syllabus.IdMatiere = int.Parse(cbbMatieres.SelectedValue.ToString());
            syllabus.idClasse = int.Parse(cbbClasse.SelectedValue.ToString());
            db.Syllabus.Add(syllabus);
            db.SaveChanges();
            MessageBox.Show("Syllabus ajouté avec succès.");

            affichagecbb();
            affichage();
        }

    }
}
