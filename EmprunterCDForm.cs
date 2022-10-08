using Gestion_Bibliothèque.entities;
using Gestion_Bibliothèque.services;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Gestion_Bibliothèque
{
    public partial class EmprunterCDForm : MetroSetForm
    {
        private static int id;
        public static int coteCD;
        private AdherantService os;
        private OuvrageService us;
        private EmprunterService es;

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

        public void cd_load(int c)
        {
            cd.Text = us.findById(c).Auteur + "_" + us.findById(c).Titre;
        }
        //public EmprunterCDForm()
        //{
            //InitializeComponent();
        //}

        public EmprunterCDForm(int c)
        {
            InitializeComponent();
            os = new AdherantService();
            us = new OuvrageService();
            es = new EmprunterService();
            table_load();
            coteCD = c;
            cd.Text = coteCD.ToString();
            cd_load(c);
        }

        public void declorerTable()
        {
            foreach (ListViewItem l in adherantList.Items)
            {
                l.BackColor = DefaultBackColor;
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            declorerTable();
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
                        MetroSetMessageBox.Show(this, "Utilisateur ajouté avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        id = int.Parse(adherantList.Items[adherantList.Items.Count - 1].SubItems[0].Text);
                        adherantList.Items[adherantList.Items.Count - 1].BackColor = Color.LightSeaGreen;
                        adherant.Text = fullname.Text + "_" + cin.Text;
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
            foreach (ListViewItem l in adherantList.Items)
            {
                if (cin.Text == l.SubItems[2].Text || tel.Text == l.SubItems[3].Text || email.Text == l.SubItems[4].Text)
                {
                    return false;
                }
            }
            return true;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            adherantList.Items.Clear();
            foreach (Adherant l in os.findAll())
            {
                if (l.Fullname.ToUpper().Contains(search.Text.ToUpper()) || l.Id.ToString() == search.Text || l.Cin.ToUpper().Contains(search.Text.ToUpper()) || l.Email.ToUpper().Contains(search.Text.ToUpper()) || l.Tel.ToUpper().Contains(search.Text.ToUpper()))
                {
                    //MessageBox.Show(l.SubItems[2].Text);
                    adherantList.Items.Add(new ListViewItem(new[] { l.Id.ToString(), l.Fullname, l.Cin, l.Tel, l.Email }));
                }
                else
                {
                    MessageBox.Show("Vieullez le créer !");
                }

            }
        }

        private void adherantList_MouseClick(object sender, MouseEventArgs e)
        {
            declorerTable();
            adherantList.SelectedItems[0].BackColor = Color.LightSeaGreen; ;
            id = int.Parse(adherantList.SelectedItems[0].SubItems[0].Text);
            //fullname.Text = adherantList.SelectedItems[0].SubItems[1].Text;
            //cin.Text = adherantList.SelectedItems[0].SubItems[2].Text;
            //tel.Text = adherantList.SelectedItems[0].SubItems[3].Text;
            //email.Text = adherantList.SelectedItems[0].SubItems[3].Text;
            string nom = adherantList.SelectedItems[0].SubItems[1].Text;
            string cin = adherantList.SelectedItems[0].SubItems[2].Text;
            adherant.Text = nom + "_" + cin;
        }

        private void emprunterbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(adherant.Text))
            {
                MetroSetMessageBox.Show(this, "Merci de bien sélectionner ou ajouter un adherant !");
                return;
            }
            if (dateRetour.Value <= DateTime.Today)
            {
                MetroSetMessageBox.Show(this, "Merci de bien régler la date de retour!");
                return;
            }

            if (us.emprunter(id) == false)
            {
                MetroSetMessageBox.Show(this, "Impossible d'emprunter le CD car l'adhérant a dépassé la limite d'emprunts par semaine !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (es.create(new Emprunter(os.findById(id), us.findById(coteCD), DateTime.Today.ToString("yyyy-MM-dd HH:mm"), dateRetour.Value.ToString("yyyy-MM-dd HH:mm"), 0)))
            {
                Ouvrage o = us.findById(coteCD);
                o.Quantite--;
                if (us.update(o))
                {
                    MetroSetMessageBox.Show(this, "Emprunt effectué avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            Thread.Sleep(1100);


            this.Dispose();


        }
    }
}
