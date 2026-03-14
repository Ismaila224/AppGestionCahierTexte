namespace AppGestionCahierTexte
{
    partial class frmMDI
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anneeAcademiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syllabusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chefDeDepartementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsableClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.lblTopDate = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlTopbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.parametresToolStripMenuItem,
            this.utilisateursToolStripMenuItem,
            this.profilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(189, 666);
            this.menuStrip1.TabIndex = 1;
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.actionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.actionsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 18, 4, 4);
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.actionsToolStripMenuItem.Text = "⚡  Actions";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(264, 36);
            this.seDeconnecterToolStripMenuItem.Text = "   Se déconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(264, 36);
            this.quitterToolStripMenuItem.Text = "   Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // parametresToolStripMenuItem
            // 
            this.parametresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matiereToolStripMenuItem,
            this.classeToolStripMenuItem,
            this.anneeAcademiqueToolStripMenuItem,
            this.departementToolStripMenuItem,
            this.syllabusToolStripMenuItem});
            this.parametresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.parametresToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.parametresToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 14, 4, 4);
            this.parametresToolStripMenuItem.Name = "parametresToolStripMenuItem";
            this.parametresToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.parametresToolStripMenuItem.Text = "⚙  Paramètres";
            // 
            // matiereToolStripMenuItem
            // 
            this.matiereToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.matiereToolStripMenuItem.Name = "matiereToolStripMenuItem";
            this.matiereToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.matiereToolStripMenuItem.Text = "   Matière";
            this.matiereToolStripMenuItem.Click += new System.EventHandler(this.matiereToolStripMenuItem_Click);
            // 
            // classeToolStripMenuItem
            // 
            this.classeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.classeToolStripMenuItem.Name = "classeToolStripMenuItem";
            this.classeToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.classeToolStripMenuItem.Text = "   Classe";
            this.classeToolStripMenuItem.Click += new System.EventHandler(this.classeToolStripMenuItem_Click);
            // 
            // anneeAcademiqueToolStripMenuItem
            // 
            this.anneeAcademiqueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.anneeAcademiqueToolStripMenuItem.Name = "anneeAcademiqueToolStripMenuItem";
            this.anneeAcademiqueToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.anneeAcademiqueToolStripMenuItem.Text = "   Année académique";
            this.anneeAcademiqueToolStripMenuItem.Click += new System.EventHandler(this.anneeAcademiqueToolStripMenuItem_Click);
            // 
            // departementToolStripMenuItem
            // 
            this.departementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.departementToolStripMenuItem.Name = "departementToolStripMenuItem";
            this.departementToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.departementToolStripMenuItem.Text = "   Département";
            this.departementToolStripMenuItem.Click += new System.EventHandler(this.departementToolStripMenuItem_Click);
            // 
            // syllabusToolStripMenuItem
            // 
            this.syllabusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.syllabusToolStripMenuItem.Name = "syllabusToolStripMenuItem";
            this.syllabusToolStripMenuItem.Size = new System.Drawing.Size(296, 36);
            this.syllabusToolStripMenuItem.Text = "   Syllabus";
            this.syllabusToolStripMenuItem.Click += new System.EventHandler(this.syllabusToolStripMenuItem_Click);
            // 
            // utilisateursToolStripMenuItem
            // 
            this.utilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chefDeDepartementToolStripMenuItem,
            this.professeurToolStripMenuItem,
            this.responsableClasseToolStripMenuItem});
            this.utilisateursToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.utilisateursToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.utilisateursToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 14, 4, 4);
            this.utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            this.utilisateursToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.utilisateursToolStripMenuItem.Text = "👥  Utilisateurs";
            // 
            // chefDeDepartementToolStripMenuItem
            // 
            this.chefDeDepartementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chefDeDepartementToolStripMenuItem.Name = "chefDeDepartementToolStripMenuItem";
            this.chefDeDepartementToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.chefDeDepartementToolStripMenuItem.Text = "   Chef de département";
            this.chefDeDepartementToolStripMenuItem.Click += new System.EventHandler(this.chefDeDepartementToolStripMenuItem_Click);
            // 
            // professeurToolStripMenuItem
            // 
            this.professeurToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.professeurToolStripMenuItem.Name = "professeurToolStripMenuItem";
            this.professeurToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.professeurToolStripMenuItem.Text = "   Professeur";
            this.professeurToolStripMenuItem.Click += new System.EventHandler(this.professeurToolStripMenuItem_Click);
            // 
            // responsableClasseToolStripMenuItem
            // 
            this.responsableClasseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.responsableClasseToolStripMenuItem.Name = "responsableClasseToolStripMenuItem";
            this.responsableClasseToolStripMenuItem.Size = new System.Drawing.Size(314, 36);
            this.responsableClasseToolStripMenuItem.Text = "   Responsable Classe";
            this.responsableClasseToolStripMenuItem.Click += new System.EventHandler(this.responsableClasseToolStripMenuItem1_Click_1);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.profilToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.profilToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4, 14, 4, 4);
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.profilToolStripMenuItem.Text = "👤  Profil";
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(42)))), ((int)(((byte)(90)))));
            this.pnlTopbar.Controls.Add(this.lblAppTitle);
            this.pnlTopbar.Controls.Add(this.lblTopDate);
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(189, 0);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(905, 80);
            this.pnlTopbar.TabIndex = 10;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(3, 23);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(270, 38);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "📚  Cahier de Texte";
            // 
            // lblTopDate
            // 
            this.lblTopDate.AutoSize = true;
            this.lblTopDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTopDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.lblTopDate.Location = new System.Drawing.Point(300, 34);
            this.lblTopDate.Name = "lblTopDate";
            this.lblTopDate.Size = new System.Drawing.Size(183, 25);
            this.lblTopDate.TabIndex = 1;
            this.lblTopDate.Text = "samedi 14 mars 2026";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1094, 666);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTopbar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMDI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Cahier de Texte";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTopbar.ResumeLayout(false);
            this.pnlTopbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anneeAcademiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chefDeDepartementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsableClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syllabusToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblTopDate;
    }
}
