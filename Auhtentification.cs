using MetroSet_UI.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gestion_Bibliothèque
{
    public partial class Authentification : MetroSetForm
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=;database=gest_biblio");

        private static string auth;

        public static string Auth { get => auth; set => auth = value; }

        public Authentification()
        {
            InitializeComponent();
            showmdp.Size = new Size(86, 10);
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select * from utilisateur where login=@login and password=@password";
            cmd.Parameters.AddWithValue("@login", login.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            MySqlDataReader re = cmd.ExecuteReader();

            if (re.Read())
            {
                Auth = re.GetString("login");
                MessageBox.Show("Vous êtes connecté(e) !");
                Hide();
                if (Auth == "admin")
                {
                    Menu menu = new Menu(Auth);
                    menu.Show();
                }
                else
                {
                    MenuUser menuUser = new MenuUser(Auth);
                    menuUser.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Connexion erronée!!");
            }
            connection.Close();
        }

        
        private void showmdp_CheckedChanged(object sender)
        {
            if (showmdp.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
