using System;
using System.Drawing;
using System.Windows.Forms;
using AppGestionCahierTexte.Views.Parametre;
using AppGestionCahierTexte.Views.Utilisateurs;
using Microsoft.VisualBasic.Devices;

namespace AppGestionCahierTexte
{
    public partial class frmMDI : Form
    {
        public string profil = "";

        public frmMDI()
        {
            InitializeComponent();
            AppliquerTheme();
        }

        // ── Thème sidebar ──────────────────────────────────────────────────────
        private void AppliquerTheme()
        {
            // Couleurs du MenuStrip
            menuStrip1.BackColor = Color.FromArgb(15, 30, 60);
            menuStrip1.ForeColor = Color.White;

            // Couleurs de chaque item principal
            Color[] couleursItems = {
                Color.FromArgb(200, 215, 240),
                Color.FromArgb(200, 215, 240),
                Color.FromArgb(200, 215, 240),
                Color.FromArgb(200, 215, 240)
            };

            ToolStripMenuItem[] items = {
                actionsToolStripMenuItem,
                parametresToolStripMenuItem,
                utilisateursToolStripMenuItem,
                profilToolStripMenuItem
            };

            foreach (var item in items)
            {
                item.ForeColor = Color.FromArgb(200, 215, 240);
                item.BackColor = Color.FromArgb(15, 30, 60);
                item.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);

                // Sous-items
                foreach (ToolStripItem sub in item.DropDownItems)
                {
                    sub.BackColor = Color.FromArgb(22, 44, 85);
                    sub.ForeColor = Color.FromArgb(200, 215, 240);
                    sub.Font = new Font("Segoe UI", 10f);
                }
            }
        }

        // ── Événements ────────────────────────────────────────────────────────
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
            foreach (Form chform in this.MdiChildren)
                chform.Close();
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmMatiere f = new frmMatiere();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmClasse f = new frmClasse();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void anneeAcademiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmAnneeAcademique f = new frmAnneeAcademique();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer myComputer = new Computer();
            this.Width = myComputer.Screen.Bounds.Width;
            this.Height = myComputer.Screen.Bounds.Height;
            this.Location = new Point(0, 0);

            // Mise à jour de la date dans la topbar
            lblTopDate.Text = DateTime.Now.ToString(
                "dddd d MMMM yyyy",
                new System.Globalization.CultureInfo("fr-FR"));

            // Visibilité selon le profil
            if (this.profil == "ADMIN")
            {
                utilisateursToolStripMenuItem.Visible = true;
                parametresToolStripMenuItem.Visible = true;
            }
            else
            {
                utilisateursToolStripMenuItem.Visible = false;
                parametresToolStripMenuItem.Visible = false;
            }
        }

        private void chefDeDepartementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmChefDepartement f = new frmChefDepartement();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmProfesseur prof = new frmProfesseur();
            prof.MdiParent = this;
            prof.Show();
            prof.WindowState = FormWindowState.Maximized;
        }

        private void departementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmDepatement dep = new frmDepatement();
            dep.MdiParent = this;
            dep.Show();
            dep.WindowState = FormWindowState.Maximized;
        }

        private void responsableClasseToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            fermer();
            frmResponsableClasse RsC = new frmResponsableClasse();
            RsC.MdiParent = this;
            RsC.Show();
            RsC.WindowState = FormWindowState.Maximized;
        }

        private void syllabusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fermer();
            frmSylalabus f = new frmSylalabus();
            f.MdiParent = this;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
        }
    }
}
