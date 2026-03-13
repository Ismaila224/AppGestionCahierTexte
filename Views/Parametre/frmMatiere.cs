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
    public partial class frmMatiere : Form
    {
        public frmMatiere()
        {
            InitializeComponent();
            LoadData();
        }
        List<Matiere> listMatiere = new List<Matiere>();
        BdCahierTexteContext db = new BdCahierTexteContext();

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Matiere matiere = new Matiere();
            matiere.libelleMatiere = txtLibelle.Text;
            matiere.VolumeHoreureMatiere = int.Parse(txtVolumeH.Text);
            db.Matieres.Add(matiere);
            db.SaveChanges();
            Clear();
            LoadData();
            MessageBox.Show("Matière ajoutée avec succès.");
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMatiere.CurrentRow != null)
                {

                    Matiere matiere = dgvMatiere.CurrentRow.DataBoundItem as Matiere;
                    if (matiere != null)
                    {
                        txtLibelle.Text = matiere.libelleMatiere;
                        txtVolumeH.Text = matiere.VolumeHoreureMatiere.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une matière dans la liste.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMatiere.CurrentRow != null)
                {
                    Matiere matiere = dgvMatiere.CurrentRow.DataBoundItem as Matiere;
                    if (matiere != null)
                    {
                        db.Matieres.Remove(matiere);
                        db.SaveChanges();
                        MessageBox.Show("Matière supprimée avec succès.");
                        LoadData();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une matière à supprimer.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMatiere.CurrentRow != null)
                {
                    Matiere matiere = dgvMatiere.CurrentRow.DataBoundItem as Matiere;
                    if (matiere != null)
                    {
                        matiere.libelleMatiere = txtLibelle.Text;
                        matiere.VolumeHoreureMatiere = int.Parse(txtVolumeH.Text);
                        db.SaveChanges();
                        MessageBox.Show("Matière modifiée avec succès.");
                        LoadData();
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une matière à modifier.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadData()
        {
            listMatiere = db.Matieres.ToList();
            dgvMatiere.DataSource = null;
            dgvMatiere.DataSource = listMatiere;
        }
        public void Clear()
        {
            txtLibelle.Text = "";
            txtVolumeH.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
