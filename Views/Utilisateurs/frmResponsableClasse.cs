using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AppGestionCahierTexte.Models;
using AppGestionCahierTexte.Shared ;
using System.Data.Entity;


namespace AppGestionCahierTexte.Views.Utilisateurs
{
    public partial class frmResponsableClasse : Form
    {
        public frmResponsableClasse()
        {
            InitializeComponent();
			affichage();
            chargementCbb();
        }
		//List<ResponsableClasse> responsables = new List<ResponsableClasse>();
         BdCahierTexteContext db = new BdCahierTexteContext();
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string mdp = "passer123";
                MD5 md5Hash = MD5.Create();

                string mdpDefaut = Crypto.GetMd5Hash(md5Hash, mdp);

                if (verifSaisie())
                {
                    Classe classe = cbbClasse.SelectedItem as Classe;
                    ResponsableClasse responsable = new ResponsableClasse
                    {
                        nomU = txtNom.Text,
                        prenomU = txtPrenom.Text,
                        adresseU = txtAdresse.Text,
                        emailU = txtEmail.Text,
                        telephoneU = txtTel.Text,
                        identifiantU = txtIdentifiant.Text,
                        motDePasseU = mdpDefaut,
                        MatriculeApprenant = "",
                        idClasse = classe.idClasse ,

                    };
                    db.ResponsableClasse.Add(responsable);
                    db.SaveChanges();
                    responsable.MatriculeApprenant = "R-" + txtPrenom.Text.Substring(0, 1).ToUpper() + txtNom.Text.Substring(0, 1).ToUpper() + "-" + responsable.IdU.ToString().PadLeft(3, '0');
                    db.SaveChanges();
                    clear();
                    affichage();

                }
                else
                {
                    MessageBox.Show("Remplir tous les champs");
                }
            }catch(Exception ex)
            {
                  MessageBox.Show(ex.Message);
            }
		}

        public void chargementCbb()
        {
            List<Classe> classes = new List<Classe>();
            classes = db.Classe.ToList();
            classes.Insert(0, new Classe
            {
                idClasse = 0,
                LibelleClasse = "Sélectionner"
            });
            this.cbbClasse.Items.Clear();
            this.cbbClasse.DataSource = classes;
            this.cbbClasse.DisplayMember = "LibelleClasse";
            this.cbbClasse.ValueMember = "idClasse";
            cbbClasse.SelectedIndex = 0;

        }


        public void clear()
        {
            this.txtNom.Text = string.Empty;
            this.txtPrenom.Text = string.Empty;
            this.txtAdresse.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtTel.Text = string.Empty;
            this.txtIdentifiant.Text = string.Empty;
            this.txtMat.Text = string.Empty;
            chargementCbb();
        }
        public void affichage()
        {
            //responsables.Clear();

            var responsables = db.ResponsableClasse
				.Include(r => r.Classe)
				.Select(r => new
                {
                    r.IdU,
					Matricule = r.MatriculeApprenant,
                    Nom = r.nomU,
                    Prenom = r.prenomU,
                    Classe = r.Classe.LibelleClasse,
					Adresse = r.prenomU,
                    Email = r.emailU,
                    Telephone = r.telephoneU,
                    Identifiant = r.identifiantU,

                })
				.ToList();
            

            dgvResponsable.DataSource = null;
            dgvResponsable.DataSource = responsables;
            dgvResponsable.Columns["IdU"].Visible = false;

		}

        public Boolean verifSaisie()
        {
            
            return !(string.IsNullOrEmpty(txtNom.Text)) ||
					!(string.IsNullOrEmpty(txtPrenom.Text)) ||
					!(string.IsNullOrEmpty(txtAdresse.Text)) ||
					!(string.IsNullOrEmpty(txtEmail.Text)) ||
					!(string.IsNullOrEmpty(txtTel.Text)) ||
					!(string.IsNullOrEmpty(txtIdentifiant.Text)) ||
					!(string.IsNullOrEmpty(txtMat.Text))
				;
		}

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
           if (dgvResponsable.CurrentRow != null)
           {
                int id = (int)dgvResponsable.CurrentRow.Cells["IdU"].Value;
                ResponsableClasse responsable = db.ResponsableClasse.Find(id);
				//ResponsableClasse responsable = dgvResponsable.CurrentRow.DataBoundItem as ResponsableClasse;
                if (responsable != null)
                {
                    try
                    {
                        txtNom.Text = responsable.nomU;
                        txtPrenom.Text = responsable.prenomU;
                        txtEmail.Text = responsable.emailU;
                        txtAdresse.Text = responsable.adresseU;
                        txtMat.Text = responsable.MatriculeApprenant;
                        txtTel.Text = responsable.telephoneU;
                        txtIdentifiant.Text = responsable.identifiantU;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        Logger.Error("Erreur de selection", ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Aucune ligne selectionner");
                }
                }
           else
           {
                MessageBox.Show("Choisir la ligne à selectionner");
           }
        }
        

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvResponsable.CurrentRow != null)
                {
                    ResponsableClasse responsable = this.dgvResponsable.CurrentRow.DataBoundItem as ResponsableClasse;
                    if (responsable != null)
                    {
                        db.ResponsableClasse.Remove(responsable);
                        db.SaveChanges();
                        affichage();
                        txtNom.Text = "";
                        txtPrenom.Text = "";
                        txtEmail.Text = "";
                        txtAdresse.Text = "";
                        txtMat.Text = "";
                        txtTel.Text = "";
                        txtIdentifiant.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Aucune ligne selectionner");
                    }
                }
                else
                {
                    MessageBox.Show("Choisir la supprimer");
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResponsable.CurrentRow != null)
                {
                    ResponsableClasse responsable = dgvResponsable.CurrentRow.DataBoundItem as ResponsableClasse;
                    if (responsable != null)
                    {
                        if (verifSaisie())
                        {
                            responsable.nomU = txtNom.Text;
                            responsable.prenomU = txtPrenom.Text;
                            responsable.emailU = txtEmail.Text;
                            responsable.adresseU = txtAdresse.Text;
                            responsable.MatriculeApprenant = txtMat.Text;
                            responsable.telephoneU = txtTel.Text;
                            responsable.identifiantU = txtIdentifiant.Text;
                            db.SaveChanges();
                            affichage();
                        }
                        else
                        {
                            MessageBox.Show("Remplir tous les champs");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune ligne selectionner");
                    }
                }
                else
                {
                    MessageBox.Show("Choisir la ligne à selectionner");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
