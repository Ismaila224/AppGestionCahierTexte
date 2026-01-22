namespace AppGestionCahierTexte
{
    partial class frmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.txtIdentifiant = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnQuitter = new System.Windows.Forms.Button();
			this.btnSeConnecter = new System.Windows.Forms.Button();
			this.txtMostDePasse = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(71, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Identifiant";
			// 
			// txtIdentifiant
			// 
			this.txtIdentifiant.Location = new System.Drawing.Point(74, 103);
			this.txtIdentifiant.Name = "txtIdentifiant";
			this.txtIdentifiant.Size = new System.Drawing.Size(472, 22);
			this.txtIdentifiant.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(71, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mot de passe";
			// 
			// btnQuitter
			// 
			this.btnQuitter.BackColor = System.Drawing.Color.Lime;
			this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitter.Location = new System.Drawing.Point(74, 307);
			this.btnQuitter.Name = "btnQuitter";
			this.btnQuitter.Size = new System.Drawing.Size(180, 40);
			this.btnQuitter.TabIndex = 4;
			this.btnQuitter.Tag = "4";
			this.btnQuitter.Text = "&Quitter";
			this.btnQuitter.UseVisualStyleBackColor = false;
			this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
			// 
			// btnSeConnecter
			// 
			this.btnSeConnecter.BackColor = System.Drawing.Color.Lime;
			this.btnSeConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeConnecter.Location = new System.Drawing.Point(362, 307);
			this.btnSeConnecter.Name = "btnSeConnecter";
			this.btnSeConnecter.Size = new System.Drawing.Size(184, 40);
			this.btnSeConnecter.TabIndex = 5;
			this.btnSeConnecter.Tag = "3";
			this.btnSeConnecter.Text = "&Se connecter";
			this.btnSeConnecter.UseVisualStyleBackColor = false;
			this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
			// 
			// txtMostDePasse
			// 
			this.txtMostDePasse.Location = new System.Drawing.Point(74, 214);
			this.txtMostDePasse.Name = "txtMostDePasse";
			this.txtMostDePasse.Size = new System.Drawing.Size(472, 22);
			this.txtMostDePasse.TabIndex = 6;
			this.txtMostDePasse.Tag = "2";
			this.txtMostDePasse.UseSystemPasswordChar = true;
			// 
			// frmConnexion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(597, 460);
			this.ControlBox = false;
			this.Controls.Add(this.txtMostDePasse);
			this.Controls.Add(this.btnSeConnecter);
			this.Controls.Add(this.btnQuitter);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIdentifiant);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Name = "frmConnexion";
			this.Text = "Gestion cahier de texte";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.TextBox txtMostDePasse;
    }
}

