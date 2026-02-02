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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNouveauPassword = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnNouveauPassword = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNouveauPassword);
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.txtNouveauPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(61, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot de pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saisir votre nouveau password";
            // 
            // txtNouveauPassword
            // 
            this.txtNouveauPassword.Location = new System.Drawing.Point(79, 114);
            this.txtNouveauPassword.Multiline = true;
            this.txtNouveauPassword.Name = "txtNouveauPassword";
            this.txtNouveauPassword.Size = new System.Drawing.Size(336, 33);
            this.txtNouveauPassword.TabIndex = 2;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(79, 175);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(155, 36);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnNouveauPassword
            // 
            this.btnNouveauPassword.Location = new System.Drawing.Point(259, 176);
            this.btnNouveauPassword.Name = "btnNouveauPassword";
            this.btnNouveauPassword.Size = new System.Drawing.Size(156, 36);
            this.btnNouveauPassword.TabIndex = 4;
            this.btnNouveauPassword.Text = "Modifier";
            this.btnNouveauPassword.UseVisualStyleBackColor = true;
            this.btnNouveauPassword.Click += new System.EventHandler(this.btnNouveauPassword_Click);
            // 
            // frmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 355);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPassword";
            this.Text = "frmPassword";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouveauPassword;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtNouveauPassword;
    }
}