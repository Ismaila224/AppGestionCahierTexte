namespace AppGestionCahierTexte.Views.Utilisateurs
{
    partial class frmPassword
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
            this.btnNouveauPassword = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txtNouveauPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNouveauPassword
            // 
            this.btnNouveauPassword.Location = new System.Drawing.Point(392, 340);
            this.btnNouveauPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNouveauPassword.Name = "btnNouveauPassword";
            this.btnNouveauPassword.Size = new System.Drawing.Size(176, 45);
            this.btnNouveauPassword.TabIndex = 4;
            this.btnNouveauPassword.Text = "Modifier";
            this.btnNouveauPassword.UseVisualStyleBackColor = true;
            this.btnNouveauPassword.Click += new System.EventHandler(this.btnNouveauPassword_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(190, 339);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(174, 45);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // txtNouveauPassword
            // 
            this.txtNouveauPassword.Location = new System.Drawing.Point(190, 262);
            this.txtNouveauPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNouveauPassword.Multiline = true;
            this.txtNouveauPassword.Name = "txtNouveauPassword";
            this.txtNouveauPassword.Size = new System.Drawing.Size(378, 40);
            this.txtNouveauPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saisir votre nouveau password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de pass";
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 575);
            this.ControlBox = false;
            this.Controls.Add(this.btnNouveauPassword);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNouveauPassword);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPassword";
            this.Text = "frmPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouveauPassword;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtNouveauPassword;
    }
}