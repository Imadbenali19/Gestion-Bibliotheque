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
    public partial class GestionAdherant : MetroSetForm
    {

        private static int id;
        private AdherantService os;
        public void table_load()
        {
            search.Text = "";
            fullname.Text = "";
            cin.Text = "";
            email.Text = "";
            tel.Text = "";
            adherantList.Items.Clear();
            foreach (Adherant u in os.findAll())
            {
                ListViewItem list_user = new ListViewItem();
                list_user.SubItems[0].Text = u.Id.ToString();
                list_user.SubItems.Add(u.Fullname);
                list_user.SubItems.Add(u.Cin);
                list_user.SubItems.Add(u.Tel);
                list_user.SubItems.Add(u.Email);

                adherantList.Items.Add(list_user);
            }
        }
        public GestionAdherant()
        {
            InitializeComponent();
            os = new AdherantService();
            table_load();
        }

        private void adherantList_MouseClick(object sender, MouseEventArgs e)
        {
            addbtn.Enabled = false;
            id = int.Parse(adherantList.SelectedItems[0].SubItems[0].Text);
            fullname.Text = adherantList.SelectedItems[0].SubItems[1].Text;
            cin.Text = adherantList.SelectedItems[0].SubItems[2].Text;
            tel.Text = adherantList.SelectedItems[0].SubItems[3].Text;
            email.Text = adherantList.SelectedItems[0].SubItems[4].Text;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fullname.Text) || string.IsNullOrWhiteSpace(cin.Text) || string.IsNullOrWhiteSpace(tel.Text) || string.IsNullOrWhiteSpace(email.Text))
            {
                //MetroSetMessageBox.Show("Vieullez remplir les différents champs !");
                MetroSetMessageBox.Show(this, "Vieullez remplir les différents champs !");
                return;
            }

            if (MetroSetMessageBox.Show(this, "Etes-vous sûr d'ajouter cet adherant ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (verify() == true)
                {
                    if (os.create(new Adherant(fullname.Text, cin.Text, tel.Text, email.Text)))
                    {
                        table_load();
                        MetroSetMessageBox.Show(this, "Adhérant ajouté avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Adherant déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool verify()
        {
            foreach(ListViewItem l in adherantList.Items)
            {
                if (cin.Text == l.SubItems[2].Text || tel.Text == l.SubItems[3].Text || email.Text == l.SubItems[4].Text)
                {
                    return false;
                }
            }
            return true;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (adherantList.SelectedItems.Count == 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un adhérant de la liste !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(fullname.Text) && !string.IsNullOrWhiteSpace(cin.Text) && !string.IsNullOrWhiteSpace(tel.Text) && !string.IsNullOrWhiteSpace(email.Text))
            {
                if (MetroSetMessageBox.Show(this, "Etes-vous sûr de modifier cet adhérant ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (verify() == true || cin.Text == adherantList.SelectedItems[0].SubItems[2].Text)
                    {
                        if(verify() == true || tel.Text == adherantList.SelectedItems[0].SubItems[3].Text)
                        {
                            if(verify() == true || email.Text == adherantList.SelectedItems[0].SubItems[4].Text)
                            {
                                Adherant u = os.findById(id);
                                u.Fullname = fullname.Text;
                                u.Cin = cin.Text;
                                u.Tel = tel.Text;
                                u.Email = email.Text;

                                if (os.update(u))
                                {
                                    table_load();
                                    MetroSetMessageBox.Show(this, "Adhérant modifié avec succès !", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                addbtn.Enabled = true;
                            }
                        }
                        
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this, "Adhérant déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (adherantList.SelectedItems.Count <= 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un adhérant de la liste !");
                return;

            }
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer cet adhérant ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (os.delete(os.findById(id)))
                {
                    table_load();
                    MetroSetMessageBox.Show(this, "Adhérant supprimé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                addbtn.Enabled = true;
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer tous ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                adherantList.Items.Clear();
                foreach (Adherant u in os.findAll())
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
            
            adherantList.Items.Clear();
            foreach (Adherant l in os.findAll())
            {
                if (l.Fullname.ToUpper().Contains(search.Text.ToUpper()) || l.Id.ToString() == search.Text || l.Cin.ToUpper().Contains(search.Text.ToUpper()) || l.Tel.ToUpper().Contains(search.Text.ToUpper()) || l.Email.ToUpper().Contains(search.Text.ToUpper()))
                {
                   
                    //MessageBox.Show(l.SubItems[2].Text);
                    adherantList.Items.Add(new ListViewItem(new[] { l.Id.ToString(), l.Fullname, l.Cin, l.Tel,l.Email }));
                }

            }
        }
    }
}
