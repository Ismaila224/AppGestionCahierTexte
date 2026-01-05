namespace AppGestionCahierTexte.Views.Parametre
{
    partial class frmAnneeAcademique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLibelleAnneeAcademique = new System.Windows.Forms.TextBox();
            this.dgvAnneeAcademique = new System.Windows.Forms.DataGridView();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtValueAnneeAcademique = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnneeAcademique)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "LibelleAnnee Academique";
            // 
            // txtLibelleAnneeAcademique
            // 
            this.txtLibelleAnneeAcademique.Location = new System.Drawing.Point(478, 254);
            this.txtLibelleAnneeAcademique.Multiline = true;
            this.txtLibelleAnneeAcademique.Name = "txtLibelleAnneeAcademique";
            this.txtLibelleAnneeAcademique.Size = new System.Drawing.Size(273, 37);
            this.txtLibelleAnneeAcademique.TabIndex = 1;
            // 
            // dgvAnneeAcademique
            // 
            this.dgvAnneeAcademique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnneeAcademique.Location = new System.Drawing.Point(783, 254);
            this.dgvAnneeAcademique.Name = "dgvAnneeAcademique";
            this.dgvAnneeAcademique.RowHeadersWidth = 51;
            this.dgvAnneeAcademique.RowTemplate.Height = 24;
            this.dgvAnneeAcademique.Size = new System.Drawing.Size(472, 384);
            this.dgvAnneeAcademique.TabIndex = 2;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(478, 666);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(212, 35);
            this.btnQuitter.TabIndex = 17;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(478, 596);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(212, 35);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(478, 525);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(212, 40);
            this.Modifier.TabIndex = 15;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(478, 466);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(212, 42);
            this.btnSelectionner.TabIndex = 14;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(478, 400);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(212, 43);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtValueAnneeAcademique
            // 
            this.txtValueAnneeAcademique.Location = new System.Drawing.Point(478, 339);
            this.txtValueAnneeAcademique.Multiline = true;
            this.txtValueAnneeAcademique.Name = "txtValueAnneeAcademique";
            this.txtValueAnneeAcademique.Size = new System.Drawing.Size(273, 37);
            this.txtValueAnneeAcademique.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Value Annee Academique";
            // 
            // frmAnneeAcademique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 767);
            this.ControlBox = false;
            this.Controls.Add(this.txtValueAnneeAcademique);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvAnneeAcademique);
            this.Controls.Add(this.txtLibelleAnneeAcademique);
            this.Controls.Add(this.label1);
            this.Name = "frmAnneeAcademique";
            this.Text = "Annee Academique";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnneeAcademique)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLibelleAnneeAcademique;
        private System.Windows.Forms.DataGridView dgvAnneeAcademique;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtValueAnneeAcademique;
        private System.Windows.Forms.Label label2;
    }
}