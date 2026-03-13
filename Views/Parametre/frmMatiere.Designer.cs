namespace AppGestionCahierTexte.Views.Parametre
{
    partial class frmMatiere
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvMatiere = new System.Windows.Forms.DataGridView();
            this.txtVolumeHorraire = new System.Windows.Forms.Label();
            this.txtVolumeH = new System.Windows.Forms.TextBox();
            this.libelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(1086, 874);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(212, 35);
            this.btnQuitter.TabIndex = 61;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Brown;
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(149, 533);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(212, 35);
            this.btnSupprimer.TabIndex = 60;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Modifier.ForeColor = System.Drawing.Color.White;
            this.Modifier.Location = new System.Drawing.Point(149, 471);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(212, 40);
            this.Modifier.TabIndex = 59;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectionner.Location = new System.Drawing.Point(155, 145);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(212, 42);
            this.btnSelectionner.TabIndex = 58;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = false;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Blue;
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(149, 406);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(212, 43);
            this.btnAjouter.TabIndex = 57;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvMatiere
            // 
            this.dgvMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatiere.Location = new System.Drawing.Point(459, 250);
            this.dgvMatiere.Name = "dgvMatiere";
            this.dgvMatiere.RowHeadersWidth = 51;
            this.dgvMatiere.RowTemplate.Height = 24;
            this.dgvMatiere.Size = new System.Drawing.Size(586, 360);
            this.dgvMatiere.TabIndex = 56;
            // 
            // txtVolumeHorraire
            // 
            this.txtVolumeHorraire.AutoSize = true;
            this.txtVolumeHorraire.Location = new System.Drawing.Point(146, 291);
            this.txtVolumeHorraire.Name = "txtVolumeHorraire";
            this.txtVolumeHorraire.Size = new System.Drawing.Size(100, 16);
            this.txtVolumeHorraire.TabIndex = 2;
            this.txtVolumeHorraire.Text = "volume horraire";
            // 
            // txtVolumeH
            // 
            this.txtVolumeH.Location = new System.Drawing.Point(150, 315);
            this.txtVolumeH.Name = "txtVolumeH";
            this.txtVolumeH.Size = new System.Drawing.Size(239, 22);
            this.txtVolumeH.TabIndex = 45;
            // 
            // libelle
            // 
            this.libelle.AutoSize = true;
            this.libelle.Location = new System.Drawing.Point(146, 224);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(47, 16);
            this.libelle.TabIndex = 1;
            this.libelle.Text = "Libellé";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(150, 250);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(239, 22);
            this.txtLibelle.TabIndex = 1;
            // 
            // frmMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 647);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dgvMatiere);
            this.Controls.Add(this.txtVolumeHorraire);
            this.Controls.Add(this.txtVolumeH);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label1);
            this.Name = "frmMatiere";
            this.Text = "Matiere";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgvMatiere;
        private System.Windows.Forms.Label txtVolumeHorraire;
        private System.Windows.Forms.TextBox txtVolumeH;
        private System.Windows.Forms.Label libelle;
        private System.Windows.Forms.TextBox txtLibelle;
    }
}