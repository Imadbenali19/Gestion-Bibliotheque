using Gestion_Bibliothèque.entities;
using Gestion_Bibliothèque.services;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Bibliothèque
{
    public partial class GestionEmprunt : MetroSetForm
    {

        private static int id;
        private EmprunterService os;
        public void table_load()
        {
            string r = "Non";
            empruntList.Items.Clear();
            foreach (Emprunter u in os.findAll())
            {
                if (u.Retourne == 1)
                {
                    r = "Oui";
                }
                else
                {
                    r = "Non";
                }

                ListViewItem list_user = new ListViewItem();
                list_user.SubItems[0].Text = u.Id.ToString();
                list_user.SubItems.Add(u.getAdherant().Fullname+"_"+ u.getAdherant().Cin);
                if (u.getOuvrage().Type == "Periodique")
                {
                    list_user.SubItems.Add(u.getOuvrage().Type+"_"+ u.getOuvrage().Nom+"_"+ u.getOuvrage().Num);
                }
                else
                {
                    list_user.SubItems.Add(u.getOuvrage().Type + "_" + u.getOuvrage().Auteur + "_" + u.getOuvrage().Titre);
                }
                list_user.SubItems.Add(u.DateDebut);
                list_user.SubItems.Add(u.DateFin);

                list_user.SubItems.Add(r);

                empruntList.Items.Add(list_user);
            }
        }

        public GestionEmprunt()
        {
            InitializeComponent();
            os = new EmprunterService();
            table_load();
        }

        private void retourbtn_Click(object sender, EventArgs e)
        {
            if (empruntList.SelectedItems.Count == 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un emprunt de la liste !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de Retourner ce livre ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Emprunter u = os.findById(id);
                u.Retourne = 1;
                if (os.update(u))
                {
                    table_load();
                    MetroSetMessageBox.Show(this, "Utilisateur modifié avec succès !", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }       
 
        }

        private void empruntList_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(empruntList.SelectedItems[0].SubItems[0].Text);
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (empruntList.SelectedItems.Count <= 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un emprunt de la liste !");
                return;

            }
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer cet emprunt ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (os.delete(os.findById(id)))
                {
                    table_load();
                    MetroSetMessageBox.Show(this, "Emprunt supprimé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer tous ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                empruntList.Items.Clear();
                foreach (Emprunter u in os.findAll())
                {
                    if (os.delete(u))
                    {

                    }
                }
                MetroSetMessageBox.Show(this, "Suppression faite!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string i = "";
            string o = "";
            string r = "";
            empruntList.Items.Clear();
            foreach (Emprunter l in os.findAll())
            {
                if (l.Retourne == 1)
                {
                    r = "Oui";
                }
                else
                {
                    r = "Non";
                }
                if (l.getAdherant().Fullname.ToUpper().Contains(search.Text.ToUpper()) || l.Id.ToString() == search.Text || l.getAdherant().Cin.ToUpper().Contains(search.Text.ToUpper()) || l.getOuvrage().Type.ToUpper().Contains(search.Text.ToUpper()) || l.getOuvrage().Titre.ToUpper().Contains(search.Text.ToUpper()) || l.getOuvrage().Auteur.ToUpper().Contains(search.Text.ToUpper()) || l.getOuvrage().Nom.ToUpper().Contains(search.Text.ToUpper()) || l.getOuvrage().Num.ToUpper().Contains(search.Text.ToUpper()) || l.DateDebut.Contains(search.Text.ToUpper()) || l.DateFin.Contains(search.Text.ToUpper()) || search.Text.ToUpper()==r.ToUpper() || search.Text.ToUpper() == r.ToUpper())
                {
                    if (l.Retourne == 1)
                        i = "Oui";
                    else
                        i = "Non";
                    if (l.getOuvrage().Type == "Periodique")
                    {
                        o=l.getOuvrage().Nom + "_" + l.getOuvrage().Num;
                    }
                    else
                    {
                        o=l.getOuvrage().Type + "_" + l.getOuvrage().Auteur + "_" + l.getOuvrage().Titre;
                    }
                    //MessageBox.Show(l.SubItems[2].Text);
                    empruntList.Items.Add(new ListViewItem(new[] { l.Id.ToString(), l.getAdherant().Fullname+"_"+l.getAdherant().Cin, o,l.DateDebut,l.DateFin, i }));
                }

            }
        }
    }
}
