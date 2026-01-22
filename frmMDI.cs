using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGestionCahierTexte.Views.Parametre;
using AppGestionCahierTexte.Views.Utilisateurs;
using Microsoft.VisualBasic.Devices;



namespace AppGestionCahierTexte
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        public string profil = "";
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();
            this.Close();
        }

        private void fermer()
        {
            Form[] charr = this.MdiChildren;

            //For each child form set the window state to Maximized 
            foreach (Form chform in charr)
            {
                //chform.WindowState = FormWindowState.Maximized;
                chform.Close();
            }
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmMatiere f = new frmMatiere();

            //Set parent form for the child window 
            f.MdiParent = this;

            //Display the child window
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmClasse f = new frmClasse();

            //Set parent form for the child window 
            f.MdiParent = this;

            //Display the child window
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void anneeAcademiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmAnneeAcademique f = new frmAnneeAcademique();

            //Set parent form for the child window 
            f.MdiParent = this;

            //Display the child window
            f.Show();
            f.WindowState = FormWindowState.Maximized;

        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);
            if(this.profil != "ADMIN")
            {
                this.responsableClasseToolStripMenuItem.Visible = false;

			}
        }

        private void chefDeDepartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmChefDepartement f = new frmChefDepartement();
            //Set parent form for the child window
            f.MdiParent = this;
            //Display the child window
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void responsableClasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmResponsableClasse RsC = new frmResponsableClasse();
            //Set parent form for the child window
            RsC.MdiParent = this;
            //Display the child window
            RsC.Show();
            RsC.WindowState = FormWindowState.Maximized;
        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmProfesseur prof = new frmProfesseur();
            //Set parent form for the child window
            prof.MdiParent = this;
            //Display the child window
            prof.Show();
            prof.WindowState = FormWindowState.Maximized;
        }

        private void departementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            //Create a new instance of the MDI child template form
            frmDepatement dep = new frmDepatement();
            //Set parent form for the child window
            dep.MdiParent = this;
            //Display the child window
            dep.Show();
            dep.WindowState = FormWindowState.Maximized;
        }
    }
}
