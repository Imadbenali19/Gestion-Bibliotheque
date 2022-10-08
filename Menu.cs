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
    public partial class Menu : MetroSetForm
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        public Menu(string c)
        {
            InitializeComponent();
            auth.Items.Add(c);
            auth.Items.Add("Logout");
            auth.SelectedItem = c;
        }

        private void usersbtn_Click(object sender, EventArgs e)
        {
            //MenuPanel.Controls.Clear();
            //GestionUsers gu = new GestionUsers();
            //gu.TopLevel=false;
            //gu.TopMost = true;
            //MenuPanel.Controls.Add(gu);
            //gu.Show();
            showForm(new GestionUsers());
        }

        private void ouvragebtn_Click(object sender, EventArgs e)
        {
            //MenuPanel.Controls.Clear();
            //GestionOuvrage go = new GestionOuvrage();
            //go.TopLevel = false;
            //go.TopMost = true;
            //MenuPanel.Controls.Add(go);
            //go.Show();
            showForm(new GestionOuvrage());
        }

        private void showForm(object form)
        {
            MenuPanel.Controls.Clear();
            Form go = form as Form;
            go.TopLevel = false;
            //go.TopMost = true;
            MenuPanel.Controls.Add(go);
            MenuPanel.Tag = go;
            go.Show();
        }

        private void empruntbtn_Click(object sender, EventArgs e)
        {
            showForm(new GestionEmprunt());
        }

        private void adherantbtn_Click(object sender, EventArgs e)
        {
            showForm(new GestionAdherant());
        }

        private void auth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auth.SelectedItem.ToString() == "Logout")
            {
                MessageBox.Show("Vous êtes déconnecté(e)!");
                Authentification a = new Authentification();
                Thread.Sleep(0);
                a.Show();
                Dispose();
                
            }
        }

        private void statistiquebtn_Click(object sender, EventArgs e)
        {
            showForm(new StatistiquesForm());
        }
    }
}
