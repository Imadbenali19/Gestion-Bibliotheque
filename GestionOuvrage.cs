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
    public partial class GestionOuvrage : MetroSetForm
    {
        private static int id;
        public static int coteLivre;
        public static int coteCD;
        public static int cotePeriodique;
        private OuvrageService os;

        public void table_load()
        {
            search.Text = "";
            auteur.Text = "";
            titre.Text = "";
            editeur.Text = "";
            quantite.Value = 0;
            livreList.Items.Clear();
            foreach (Ouvrage u in os.findAll())
            {
                if (u.Type == "Livre")
                {
                    ListViewItem list_user = new ListViewItem();
                    list_user.SubItems[0].Text = u.Cote.ToString();
                    list_user.SubItems.Add(u.Auteur);
                    list_user.SubItems.Add(u.Titre);
                    list_user.SubItems.Add(u.Editeur);
                    list_user.SubItems.Add(u.Quantite.ToString());

                    livreList.Items.Add(list_user);
                }
                
            }
        }
        public GestionOuvrage()
        {
            InitializeComponent();
            os = new OuvrageService();
            table_load();
            table2_load();
            table3_load();
        }

        //LIVRE PAGE
        private void livreList_MouseClick(object sender, MouseEventArgs e)
        {
            addbtn.Enabled = false;
            id = int.Parse(livreList.SelectedItems[0].SubItems[0].Text);
            auteur.Text = livreList.SelectedItems[0].SubItems[1].Text;
            titre.Text = livreList.SelectedItems[0].SubItems[2].Text;
            editeur.Text = livreList.SelectedItems[0].SubItems[3].Text;
            quantite.Text = livreList.SelectedItems[0].SubItems[4].Text;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(auteur.Text) || string.IsNullOrWhiteSpace(editeur.Text) || string.IsNullOrWhiteSpace(titre.Text) || string.IsNullOrWhiteSpace(quantite.Text))
            {
                //MetroSetMessageBox.Show("Vieullez remplir les différents champs !");
                MetroSetMessageBox.Show(this, "Vieullez remplir les différents champs !");
                return;
            }

            if (MetroSetMessageBox.Show(this, "Etes-vous sûr d'ajouter ce livre ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (verify() == true)
                {
                    if (os.create(new Ouvrage(auteur.Text, titre.Text, editeur.Text, null, null, null, "Livre", int.Parse(quantite.Text))))
                    {
                        table_load();
                        MetroSetMessageBox.Show(this, "Utilisateur ajouté avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Livre déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
        }

        private bool verify()
        {
            foreach (ListViewItem l in livreList.Items)
            {
                if (titre.Text == l.SubItems[2].Text)
                {
                    return false;
                }
            }
            return true;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (livreList.SelectedItems.Count == 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un livre de la liste !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(auteur.Text) && !string.IsNullOrWhiteSpace(editeur.Text) && !string.IsNullOrWhiteSpace(titre.Text) && !string.IsNullOrWhiteSpace(quantite.Text))
            {
                if (MetroSetMessageBox.Show(this, "Etes-vous sûr de modifier ce livre ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (verify() == true || titre.Text == livreList.SelectedItems[0].SubItems[2].Text)
                    {
                        Ouvrage u = os.findById(id);
                        u.Auteur = auteur.Text;
                        u.Editeur = editeur.Text;
                        u.Titre = titre.Text;
                        u.Quantite = int.Parse(quantite.Text);

                        if (os.update(u))
                        {
                            table_load();
                            MetroSetMessageBox.Show(this, "Livre modifié avec succès !", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        addbtn.Enabled = true;
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this, "Livre déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (livreList.SelectedItems.Count <= 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un livre de la liste !");
                return;

            }
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer ce livre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (os.delete(os.findById(id)))
                {
                    table_load();
                    MetroSetMessageBox.Show(this, "Livre supprimé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                addbtn.Enabled = true;
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer tous ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                livreList.Items.Clear();
                foreach (Ouvrage u in os.findAll())
                {
                    os.delete(u);
                }
                MetroSetMessageBox.Show(this, "Suppression faite!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void emprunterbtn_Click(object sender, EventArgs e)
        {
            if (livreList.SelectedItems.Count <= 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un livre de la liste !");
                return;
            }
            else if (int.Parse(livreList.SelectedItems[0].SubItems[4].Text)==0)
            {
                MetroSetMessageBox.Show(this, "Desolé! Quantité insuffisante !");
                return;
            }
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de emprunter ce livre ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                coteLivre = int.Parse(livreList.SelectedItems[0].SubItems[0].Text);
                EmprunterLivreForm elf = new EmprunterLivreForm(coteLivre);
                elf.Show();
  
            }
            
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            livreList.Items.Clear();
            foreach (Ouvrage l in os.findAll())
            {
                if (l.Auteur.ToUpper().Contains(search.Text.ToUpper()) || l.Cote.ToString() == search.Text || l.Titre.ToUpper().Contains(search.Text.ToUpper()) || l.Editeur.ToUpper().Contains(search.Text.ToUpper()) || l.Quantite.ToString() == search.Text)
                {
                    //MessageBox.Show(l.SubItems[2].Text);
                    livreList.Items.Add(new ListViewItem(new[] { l.Cote.ToString(), l.Auteur, l.Titre, l.Editeur, l.Quantite.ToString() }));
                }

            }
        }

        //CD PAGE

        public void table2_load()
        {
            searchcd.Text = "";
            auteur2.Text = "";
            titre2.Text = "";
            quantite2.Value = 0;
            cdList.Items.Clear();
            foreach (Ouvrage u in os.findAll())
            {
                if (u.Type == "CD")
                {
                    ListViewItem list_user = new ListViewItem();
                    list_user.SubItems[0].Text = u.Cote.ToString();
                    list_user.SubItems.Add(u.Auteur);
                    list_user.SubItems.Add(u.Titre);
                    list_user.SubItems.Add(u.Quantite.ToString());

                    cdList.Items.Add(list_user);
                }
                    
            }
        }
        private void searchcd_TextChanged(object sender, EventArgs e)
        {
            cdList.Items.Clear();
            foreach (Ouvrage l in os.findAll())
            {
                if (l.Auteur.ToUpper().Contains(searchcd.Text.ToUpper()) || l.Cote.ToString() == searchcd.Text || l.Titre.ToUpper().Contains(searchcd.Text.ToUpper()) || l.Quantite.ToString() == searchcd.Text)
                {
                    //MessageBox.Show(l.SubItems[2].Text);
                    livreList.Items.Add(new ListViewItem(new[] { l.Cote.ToString(), l.Auteur, l.Titre, l.Quantite.ToString() }));
                }

            }
        }

        private void cdList_MouseClick(object sender, MouseEventArgs e)
        {
            addbtn2.Enabled = false;
            id = int.Parse(cdList.SelectedItems[0].SubItems[0].Text);
            auteur2.Text = cdList.SelectedItems[0].SubItems[1].Text;
            titre2.Text = cdList.SelectedItems[0].SubItems[2].Text;
            quantite2.Text = cdList.SelectedItems[0].SubItems[3].Text;
        }

        private void addbtn2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(auteur2.Text) || string.IsNullOrWhiteSpace(titre2.Text) || string.IsNullOrWhiteSpace(quantite2.Text))
            {
                //MetroSetMessageBox.Show("Vieullez remplir les différents champs !");
                MetroSetMessageBox.Show(this, "Vieullez remplir les différents champs !");
                return;
            }

            if (MetroSetMessageBox.Show(this, "Etes-vous sûr d'ajouter ce CD ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (verify2() == true)
                {
                    if (os.create(new Ouvrage(auteur2.Text, titre2.Text, null, null, null, null, "CD", int.Parse(quantite2.Text))))
                    {
                        table2_load();
                        MetroSetMessageBox.Show(this, "CD ajouté avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroSetMessageBox.Show(this, "CD déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
        }

        private bool verify2()
        {
            foreach (ListViewItem l in cdList.Items)
            {
                if (titre2.Text == l.SubItems[2].Text)
                {
                    return false;
                }
            }
            return true;
        }

        private void editbtn2_Click(object sender, EventArgs e)
        {
            if (cdList.SelectedItems.Count == 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un CD de la liste !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(auteur2.Text) && !string.IsNullOrWhiteSpace(titre2.Text) && !string.IsNullOrWhiteSpace(quantite2.Text))
            {
                if (MetroSetMessageBox.Show(this, "Etes-vous sûr de modifier ce CD ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (verify2() == true || titre2.Text == cdList.SelectedItems[0].SubItems[2].Text)
                    {
                        Ouvrage u = os.findById(id);
                        u.Auteur = auteur2.Text;
                        u.Titre = titre2.Text;
                        u.Quantite = int.Parse(quantite2.Text);

                        if (os.update(u))
                        {
                            table2_load();
                            MetroSetMessageBox.Show(this, "CD modifié avec succès !", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        addbtn2.Enabled = true;
                    }
                }
                else
                {
                    MetroSetMessageBox.Show(this, "CD déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deletebtn2_Click(object sender, EventArgs e)
        {
            if (cdList.SelectedItems.Count <= 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un CD de la liste !");
                return;

            }
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer ce CD ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (os.delete(os.findById(id)))
                {
                    table2_load();
                    MetroSetMessageBox.Show(this, "CD supprimé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                addbtn2.Enabled = true;
            }
        }

        private void emprunterbtn2_Click(object sender, EventArgs e)
        {
            if (cdList.SelectedItems.Count <= 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un CD de la liste !");
                return;
            }
            else if (int.Parse(cdList.SelectedItems[0].SubItems[3].Text) == 0)
            {
                MetroSetMessageBox.Show(this, "Desolé! Quantité insuffisante !");
                return;
            }
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de emprunter ce CD ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                coteCD = int.Parse(cdList.SelectedItems[0].SubItems[0].Text);
                EmprunterCDForm ecf = new EmprunterCDForm(coteCD);
                ecf.Show();

            }
        }

        private void clearbtn2_Click(object sender, EventArgs e)
        {
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer tous ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cdList.Items.Clear();
                foreach (Ouvrage u in os.findAll())
                {
                    os.delete(u);
                }
                MetroSetMessageBox.Show(this, "Suppression faite!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //PERIODIQUE PAGE

        public void table3_load()
        {
            periodicite.SelectedIndex = 1;
            searchperio.Text = "";
            nomP.Text = "";
            numero.Text = "";
            quantite3.Value = 0;
            periodiqueList.Items.Clear();
            foreach (Ouvrage u in os.findAll())
            {
                if(u.Type== "Periodique")
                {
                    ListViewItem list_user = new ListViewItem();
                    list_user.SubItems[0].Text = u.Cote.ToString();
                    list_user.SubItems.Add(u.Nom);
                    list_user.SubItems.Add(u.Num);
                    list_user.SubItems.Add(u.Periodicite);
                    list_user.SubItems.Add(u.Quantite.ToString());

                    periodiqueList.Items.Add(list_user);
                }
                
            }
        }

        private void periodiqueList_MouseClick(object sender, MouseEventArgs e)
        {
            addbtn3.Enabled = false;
            id = int.Parse(periodiqueList.SelectedItems[0].SubItems[0].Text);
            nomP.Text = periodiqueList.SelectedItems[0].SubItems[1].Text;
            numero.Text = periodiqueList.SelectedItems[0].SubItems[2].Text;
            periodicite.SelectedItem = periodiqueList.SelectedItems[0].SubItems[3].Text;
            quantite3.Text = periodiqueList.SelectedItems[0].SubItems[4].Text;
        }

        private void searchperio_TextChanged(object sender, EventArgs e)
        {
            periodiqueList.Items.Clear();
            foreach (Ouvrage l in os.findAll())
            {
                if (l.Nom.ToUpper().Contains(searchperio.Text.ToUpper()) || l.Cote.ToString() == searchperio.Text || l.Num.ToUpper().Contains(searchperio.Text.ToUpper()) || l.Quantite.ToString() == searchperio.Text || l.Periodicite.ToString() == searchperio.Text)
                {
                    //MessageBox.Show(l.SubItems[2].Text);
                    periodiqueList.Items.Add(new ListViewItem(new[] { l.Cote.ToString(), l.Nom, l.Num,l.Periodicite, l.Quantite.ToString() }));
                }

            }
        }

        private void addbtn3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomP.Text) || string.IsNullOrWhiteSpace(numero.Text) || string.IsNullOrWhiteSpace(quantite3.Text))
            {
                //MetroSetMessageBox.Show("Vieullez remplir les différents champs !");
                MetroSetMessageBox.Show(this, "Vieullez remplir les différents champs !");
                return;
            }

            if (MetroSetMessageBox.Show(this, "Etes-vous sûr d'ajouter ce Périodique ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (verify3() == true)
                {
                    if (os.create(new Ouvrage(null, null, null, nomP.Text, numero.Text, periodicite.SelectedItem.ToString(), "Periodique", int.Parse(quantite3.Text))))
                    {
                        table3_load();
                        MetroSetMessageBox.Show(this, "Périodique ajouté avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Périodique déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
        }

        private bool verify3()
        {
            foreach (ListViewItem l in periodiqueList.Items)
            {
                if (num.Text == l.SubItems[2].Text)
                {
                    return false;
                }
            }
            return true;
        }

        private void editbtn3_Click(object sender, EventArgs e)
        {
            if (periodiqueList.SelectedItems.Count == 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un Périodique de la liste !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrWhiteSpace(nomP.Text) && !string.IsNullOrWhiteSpace(numero.Text) && !string.IsNullOrWhiteSpace(quantite3.Text))
            {
                if (MetroSetMessageBox.Show(this, "Etes-vous sûr de modifier ce CD ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (verify3() == true || num.Text == cdList.SelectedItems[0].SubItems[2].Text)
                    {
                        Ouvrage u = os.findById(id);
                        u.Nom = nomP.Text;
                        u.Num = numero.Text;
                        u.Periodicite = periodicite.SelectedItem.ToString();
                        u.Quantite = int.Parse(quantite3.Text);

                        if (os.update(u))
                        {
                            table3_load();
                            MetroSetMessageBox.Show(this, "Périodique modifié avec succès !", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        addbtn3.Enabled = true;
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this, "Périodique déjà existe !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void deletebtn3_Click(object sender, EventArgs e)
        {
            if (periodiqueList.SelectedItems.Count <= 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un Périodique de la liste !");
                return;

            }
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer ce Périodique ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (os.delete(os.findById(id)))
                {
                    table3_load();
                    MetroSetMessageBox.Show(this, "Périodique supprimé avec succès !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                addbtn3.Enabled = true;
            }
        }

        private void emprunterbtn3_Click(object sender, EventArgs e)
        {
            if (periodiqueList.SelectedItems.Count <= 0)
            {
                MetroSetMessageBox.Show(this, "Vieullez sélectionner un Périodique de la liste !");
                return;
            }
            else if (int.Parse(periodiqueList.SelectedItems[0].SubItems[4].Text) == 0)
            {
                MetroSetMessageBox.Show(this, "Desolé! Quantité insuffisante !");
                return;
            }
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de emprunter ce Périodique ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cotePeriodique = int.Parse(periodiqueList.SelectedItems[0].SubItems[0].Text);
                EmprunterPeriodiqueForm epf = new EmprunterPeriodiqueForm(cotePeriodique);
                epf.Show();

            }
        }

        private void clearbtn3_Click(object sender, EventArgs e)
        {
            if (MetroSetMessageBox.Show(this, "Etes-vous sûr de supprimer tous ?", "ATTENTION !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                periodiqueList.Items.Clear();
                foreach (Ouvrage u in os.findAll())
                {
                    os.delete(u);
                }
                MetroSetMessageBox.Show(this, "Suppression faite!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
