namespace AppGestionCahierTexte.Views.Parametre
{
    partial class frmClasse
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
            this.txtLielleClasse = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.dgvClasse = new System.Windows.Forms.DataGridView();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la Classe";
            // 
            // txtLielleClasse
            // 
            this.txtLielleClasse.Location = new System.Drawing.Point(382, 242);
            this.txtLielleClasse.Name = "txtLielleClasse";
            this.txtLielleClasse.Size = new System.Drawing.Size(212, 22);
            this.txtLielleClasse.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(382, 363);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(212, 43);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(380, 424);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(212, 42);
            this.btnSelectionner.TabIndex = 9;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(382, 498);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(212, 40);
            this.Modifier.TabIndex = 10;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(382, 560);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(212, 35);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(382, 635);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(212, 35);
            this.btnQuitter.TabIndex = 12;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // dgvClasse
            // 
            this.dgvClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasse.Location = new System.Drawing.Point(715, 208);
            this.dgvClasse.Name = "dgvClasse";
            this.dgvClasse.RowHeadersWidth = 51;
            this.dgvClasse.RowTemplate.Height = 24;
            this.dgvClasse.Size = new System.Drawing.Size(658, 464);
            this.dgvClasse.TabIndex = 13;
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(382, 320);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(210, 24);
            this.cbbAnneeAcademique.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Annee Academique";
            // 
            // frmClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 718);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.dgvClasse);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtLielleClasse);
            this.Controls.Add(this.label1);
            this.Name = "frmClasse";
            this.Text = "Classe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLielleClasse;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.DataGridView dgvClasse;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Label label2;
    }
}