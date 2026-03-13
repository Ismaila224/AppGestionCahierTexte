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
        }
        BdCahierTexteContext db = new BdCahierTexteContext();

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Matiere matiere = new Matiere();
            matiere.libelleMatiere = txtLibelle.Text;  
            matiere.VolumeHoreureMatiere = int.Parse(txtVolumeH.Text);
            db.Matieres.Add(matiere);
            db.SaveChanges();
        }
    }
}
