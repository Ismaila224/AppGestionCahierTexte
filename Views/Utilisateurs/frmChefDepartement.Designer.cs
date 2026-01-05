namespace AppGestionCahierTexte.Views.Utilisateurs
{
    partial class frmChefDepartement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbDepartementId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgvChefDepartement = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChefDepartement)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbDepartementId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 581);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbbDepartementId
            // 
            this.cbbDepartementId.FormattingEnabled = true;
            this.cbbDepartementId.Location = new System.Drawing.Point(47, 487);
            this.cbbDepartementId.Name = "cbbDepartementId";
            this.cbbDepartementId.Size = new System.Drawing.Size(291, 24);
            this.cbbDepartementId.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ajout Chef departement";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(47, 404);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 30);
            this.txtEmail.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(47, 295);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(291, 32);
            this.txtAdresse.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adresse";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(47, 200);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(291, 30);
            this.txtPrenom.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(47, 104);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(291, 31);
            this.txtNom.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Non";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSupprimer);
            this.groupBox2.Controls.Add(this.btnModifier);
            this.groupBox2.Controls.Add(this.btnQuitter);
            this.groupBox2.Controls.Add(this.btnSelectionner);
            this.groupBox2.Controls.Add(this.btnAjouter);
            this.groupBox2.Location = new System.Drawing.Point(41, 641);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 17;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(208, 136);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(142, 41);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(18, 136);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(142, 41);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(18, 194);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(332, 41);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(208, 69);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(142, 41);
            this.btnSelectionner.TabIndex = 1;
            this.btnSelectionner.Text = "Selectionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(18, 69);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(142, 41);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dgvChefDepartement
            // 
            this.dgvChefDepartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChefDepartement.Location = new System.Drawing.Point(574, 107);
            this.dgvChefDepartement.Name = "dgvChefDepartement";
            this.dgvChefDepartement.RowHeadersWidth = 51;
            this.dgvChefDepartement.RowTemplate.Height = 24;
            this.dgvChefDepartement.Size = new System.Drawing.Size(1176, 735);
            this.dgvChefDepartement.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(137, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Action";
            // 
            // frmChefDepartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 904);
            this.ControlBox = false;
            this.Controls.Add(this.dgvChefDepartement);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChefDepartement";
            this.Text = "frmChefDepartement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChefDepartement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSelectionner;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvChefDepartement;
        private System.Windows.Forms.ComboBox cbbDepartementId;
        private System.Windows.Forms.Label label7;
    }
}