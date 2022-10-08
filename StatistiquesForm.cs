using MetroSet_UI.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Bibliothèque
{
    public partial class StatistiquesForm : MetroSetForm
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=;database=gest_biblio");

        public int getNbreUsers()
        {
            int x=0;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select count(*) as nb from utilisateur";
            MySqlDataReader re = cmd.ExecuteReader();
            if(re.Read())
            {
                x = re.GetInt32("nb");
                connection.Close();
            }
            return x;
 
        }


        public int getNbreAdherant()
        {
            int x = 0;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select count(*) as nb from adherant";
            MySqlDataReader re = cmd.ExecuteReader();
            if (re.Read())
            {
                x = re.GetInt32("nb");
                connection.Close();
            }
            return x;

        }

        public int getNbreEmprunts()
        {
            int x = 0;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select count(*) as nb from emprunter";
            MySqlDataReader re = cmd.ExecuteReader();
            if (re.Read())
            {
                x = re.GetInt32("nb");
                connection.Close();
            }
            return x;

        }

        public int getNbreLivres()
        {
            int x = 0;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select count(*) as nb from ouvrage where typeOuvrage='Livre'";
            MySqlDataReader re = cmd.ExecuteReader();
            if (re.Read())
            {
                x = re.GetInt32("nb");
                connection.Close();
            }
            return x;

        }

        public int getNbreCDs()
        {
            int x = 0;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select count(*) as nb from ouvrage where typeOuvrage='CD'";
            MySqlDataReader re = cmd.ExecuteReader();
            if (re.Read())
            {
                x = re.GetInt32("nb");
                connection.Close();
            }
            return x;

        }

        public int getNbrePeriodiques()
        {
            int x = 0;
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select count(*) as nb from ouvrage where typeOuvrage='Periodique'";
            MySqlDataReader re = cmd.ExecuteReader();
            if (re.Read())
            {
                x = re.GetInt32("nb");
                connection.Close();
            }
            return x;

        }



        public StatistiquesForm()
        {
            InitializeComponent();
            nbUsers.BackColor = Color.LightBlue;
            user.BackColor = Color.Blue;

            nbAdherants.BackColor = Color.OrangeRed;
            adherant.BackColor = Color.Crimson;

            nbCDs.BackColor = Color.LightGreen;
            cd.BackColor = Color.DarkGreen;

            nbLivres.BackColor = Color.LightSalmon;
            livre.BackColor = Color.Peru;

            nbPeriodiques.BackColor = Color.Pink;
            periodique.BackColor = Color.DeepPink;

            nbEmprunts.BackColor = Color.Silver;
            emprunt.BackColor = Color.Gray;

            nbAdherants.Text= getNbreAdherant().ToString();
            nbCDs.Text= getNbreCDs().ToString();
            nbLivres.Text= getNbreLivres().ToString();
            nbPeriodiques.Text= getNbrePeriodiques().ToString();
            nbUsers.Text= getNbreUsers().ToString();
            nbEmprunts.Text = getNbreEmprunts().ToString();
        }
    }
}
