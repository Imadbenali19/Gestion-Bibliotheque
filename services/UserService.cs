using System;
using System.Collections.Generic;
using System.Text;
using Gestion_Bibliothèque.entities;
using Gestion_Bibliothèque.IDoa;
using MySql.Data.MySqlClient;

namespace Gestion_Bibliothèque.services
{
    
    class UserService : Idoa<Utilisateur>
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=;database=gest_biblio");
        public bool create(Utilisateur o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "insert into utilisateur values(null,@login,@password,@isAdmin)";

            cmd.Parameters.AddWithValue("@login", o.Login);
            cmd.Parameters.AddWithValue("@password", o.Password);
            cmd.Parameters.AddWithValue("@isAdmin", o.IsAdmin);


            if (cmd.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;   
        }

        public bool delete(Utilisateur o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "delete from utilisateur where id=@id";

            cmd.Parameters.AddWithValue("@id", o.Id);


            if (cmd.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public List<Utilisateur> findAll()
        {
            List<Utilisateur> users = new List<Utilisateur>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select * from utilisateur";

            MySqlDataReader re = cmd.ExecuteReader();

            while (re.Read()){
                users.Add(new Utilisateur(re.GetInt32("id"),re.GetString("login"),re.GetString("password"),re.GetInt32("isAdmin")));
            }
            connection.Close();
            return users;
        }

        public Utilisateur findById(int id)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select * from utilisateur where id=@id";
            cmd.Parameters.AddWithValue("@id",id);
            MySqlDataReader re = cmd.ExecuteReader();

            if (re.Read())
            {
                
                Utilisateur u= new Utilisateur(re.GetInt32("id"), re.GetString("login"), re.GetString("password"), re.GetInt32("isAdmin"));
                connection.Close();
                return u;
            }
            connection.Close();
            return null;
            
        }

        public bool update(Utilisateur o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "update utilisateur set login=@login,password=@password,isAdmin=@isAdmin where id=@id";

            cmd.Parameters.AddWithValue("@login", o.Login);
            cmd.Parameters.AddWithValue("@password", o.Password);
            cmd.Parameters.AddWithValue("@isAdmin", o.IsAdmin);
            cmd.Parameters.AddWithValue("@id", o.Id);

            if (cmd.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }
    }
}
