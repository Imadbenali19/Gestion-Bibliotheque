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
    public partial class GestionUsers : MetroSetForm
    {
        private UserService us;
        private static int id;

        public void table_load()
        {
            login.Text = "";
            password.Text = "";
            admin.SelectedIndex = 1;
            usersList.Items.Clear();
            foreach (Utilisateur u in us.findAll())
            {
                ListViewItem list_user=new ListViewItem();
                list_user.SubItems[0].Text = u.Id.ToString();
                list_user.SubItems.Add(u.Login);
                list_user.SubItems.Add(u.Password);
                if (u.IsAdmin == 1)
                {
                    list_user.SubItems.Add("Oui");
                }
                else
                {
                    list_user.SubItems.Add("Non");
                }

               usersList.Items.Add(list_user);
            }
        }
        public GestionUsers()
        {
            InitializeComponent();
            us = new UserService();
            table_load();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int i=0;
            if (string.IsNullOrWhiteSpace(login.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                //MetroSetMessageBox.Show("Vieullez remplir les différents champs !");
                MetroSetMessageBox.Show(this, "Vieullez remplir les différents champs !");
                return;
            }
            if (admin.SelectedItem.ToString().Equals("Oui"))
            {
                i = 1;
            }
            if(MetroSetMessageBox.Show(this, "Etes-vous sûr d'ajouter cet utilisateur ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                if (verify() == true)
                {
                    if (us.create(new Utilisateur(login.Text, password.Text, i)))
                    {
                        table_load();
                        MetroSetMessageBox.Show(this, "Utilisateur ajouté avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Utilisateur déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

        private bool verify()
        {
            foreach (ListViewItem l in usersList.Items)
            {
                if (login.Text == l.SubItems[1].Text)
                {
                    return false;
                }
            }
            return true;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer tous ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                usersList.Items.Clear();
                foreach (Utilisateur u in us.findAll())
                {
                    if (us.delete(u))
                    {
                        
                    }
                }
                MetroSetMessageBox.Show(this, "Suppression faite!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if(usersList.SelectedItems.Count == 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un utilisateur de la liste !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(login.Text) && !string.IsNullOrWhiteSpace(password.Text))
            {
                if (MetroSetMessageBox.Show(this, "Etes-vous sûr de modifier ce livre ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (verify() == true || login.Text == usersList.SelectedItems[0].SubItems[1].Text)
                    {
                        int i = 0;
                        if (admin.SelectedItem.ToString().Equals("Oui"))
                        {
                            i = 1;
                        }
                        Utilisateur u = us.findById(id);
                        u.Login = login.Text;
                        u.Password = password.Text;
                        u.IsAdmin = i;
                        if (us.update(u))
                        {
                            table_load();
                            MetroSetMessageBox.Show(this, "Utilisateur modifié avec succès !", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        addbtn.Enabled = true;
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this, "Utilisateur déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }     
            
        }

        private void usersList_MouseClick(object sender, MouseEventArgs e)
        {
            addbtn.Enabled = false;
            id = int.Parse(usersList.SelectedItems[0].SubItems[0].Text);
            login.Text = usersList.SelectedItems[0].SubItems[1].Text;
            password.Text = usersList.SelectedItems[0].SubItems[2].Text;
            admin.SelectedItem=usersList.SelectedItems[0].SubItems[3].Text;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count <= 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un utilisateur de la liste !");
                return;

            }
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer cet utilisateur ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (usersList.SelectedItems[0].SubItems[3].Text == "Oui")
                {
                    MetroSetMessageBox.Show(this, "Impossible de supprimer l'admin !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (us.delete(us.findById(id)))
                {
                    table_load();
                    MetroSetMessageBox.Show(this, "Utilisateur supprimé avec succès !","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                addbtn.Enabled = true;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string i = "";
            usersList.Items.Clear();
            foreach (Utilisateur l in us.findAll())
            {
                if (l.Login.ToUpper().Contains(search.Text.ToUpper()) || l.Id.ToString() == search.Text)
                {
                    if (l.IsAdmin == 1)
                        i = "Oui";
                    else
                        i = "Non";
                    
                    //MessageBox.Show(l.SubItems[2].Text);
                    usersList.Items.Add(new ListViewItem(new[] { l.Id.ToString(), l.Login, l.Password,i}));
                }

            }
        }
    }
}
