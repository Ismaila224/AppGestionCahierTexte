namespace AppGestionCahierTexte.Views.Parametre
{
    partial class frmDepatement
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvDepartement = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNomDepartement = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSupprimer = new System.Windows.Forms.Button();
			this.btnModifier = new System.Windows.Forms.Button();
			this.btnQuitter = new System.Windows.Forms.Button();
			this.btnSelectionner = new System.Windows.Forms.Button();
			this.btnAjouter = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDepartement)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.dgvDepartement);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Location = new System.Drawing.Point(398, 75);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1028, 724);
			this.panel1.TabIndex = 0;
			// 
			// dgvDepartement
			// 
			this.dgvDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDepartement.Location = new System.Drawing.Point(553, 98);
			this.dgvDepartement.Name = "dgvDepartement";
			this.dgvDepartement.RowHeadersWidth = 51;
			this.dgvDepartement.RowTemplate.Height = 24;
			this.dgvDepartement.Size = new System.Drawing.Size(341, 552);
			this.dgvDepartement.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtNomDepartement);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.btnSupprimer);
			this.groupBox2.Controls.Add(this.btnModifier);
			this.groupBox2.Controls.Add(this.btnQuitter);
			this.groupBox2.Controls.Add(this.btnSelectionner);
			this.groupBox2.Controls.Add(this.btnAjouter);
			this.groupBox2.Location = new System.Drawing.Point(106, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(412, 564);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 29);
			this.label1.TabIndex = 21;
			this.label1.Text = "Nom departement";
			// 
			// txtNomDepartement
			// 
			this.txtNomDepartement.Location = new System.Drawing.Point(39, 165);
			this.txtNomDepartement.Multiline = true;
			this.txtNomDepartement.Name = "txtNomDepartement";
			this.txtNomDepartement.Size = new System.Drawing.Size(332, 36);
			this.txtNomDepartement.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(122, 34);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(163, 29);
			this.label7.TabIndex = 18;
			this.label7.Text = "Departement";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(152, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 16);
			this.label6.TabIndex = 17;
			// 
			// btnSupprimer
			// 
			this.btnSupprimer.Location = new System.Drawing.Point(41, 431);
			this.btnSupprimer.Name = "btnSupprimer";
			this.btnSupprimer.Size = new System.Drawing.Size(329, 36);
			this.btnSupprimer.TabIndex = 4;
			this.btnSupprimer.Text = "Supprimer";
			this.btnSupprimer.UseVisualStyleBackColor = true;
			this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
			// 
			// btnModifier
			// 
			this.btnModifier.Location = new System.Drawing.Point(39, 367);
			this.btnModifier.Name = "btnModifier";
			this.btnModifier.Size = new System.Drawing.Size(332, 36);
			this.btnModifier.TabIndex = 3;
			this.btnModifier.Text = "Modifier";
			this.btnModifier.UseVisualStyleBackColor = true;
			this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
			// 
			// btnQuitter
			// 
			this.btnQuitter.Location = new System.Drawing.Point(39, 494);
			this.btnQuitter.Name = "btnQuitter";
			this.btnQuitter.Size = new System.Drawing.Size(332, 36);
			this.btnQuitter.TabIndex = 2;
			this.btnQuitter.Text = "Quitter";
			this.btnQuitter.UseVisualStyleBackColor = true;
			// 
			// btnSelectionner
			// 
			this.btnSelectionner.Location = new System.Drawing.Point(41, 302);
			this.btnSelectionner.Name = "btnSelectionner";
			this.btnSelectionner.Size = new System.Drawing.Size(329, 36);
			this.btnSelectionner.TabIndex = 1;
			this.btnSelectionner.Text = "Selectionner";
			this.btnSelectionner.UseVisualStyleBackColor = true;
			this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
			// 
			// btnAjouter
			// 
			this.btnAjouter.Location = new System.Drawing.Point(41, 236);
			this.btnAjouter.Name = "btnAjouter";
			this.btnAjouter.Size = new System.Drawing.Size(329, 36);
			this.btnAjouter.TabIndex = 0;
			this.btnAjouter.Text = "Ajouter";
			this.btnAjouter.UseVisualStyleBackColor = true;
			this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
			// 
			// frmDepatement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1367, 851);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Name = "frmDepatement";
			this.Text = "Depatement";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDepartement)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDepartement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomDepartement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnAjouter;
    }
}