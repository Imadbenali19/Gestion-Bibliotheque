using Gestion_Bibliothèque.entities;
using Gestion_Bibliothèque.IDoa;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Bibliothèque.services
{
    class AdherantService : Idoa<Adherant>
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=;database=gest_biblio");
        public bool create(Adherant o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "insert into adherant values(null,@fullname,@cin,@tel,@email)";

            cmd.Parameters.AddWithValue("@fullname", o.Fullname);
            cmd.Parameters.AddWithValue("@cin", o.Cin);
            cmd.Parameters.AddWithValue("@tel", o.Tel);
            cmd.Parameters.AddWithValue("@email", o.Email);


            if (cmd.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool delete(Adherant o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "delete from adherant where id=@id";

            cmd.Parameters.AddWithValue("@id", o.Id);


            if (cmd.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public List<Adherant> findAll()
        {
            List<Adherant> adherants = new List<Adherant>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select * from adherant";

            MySqlDataReader re = cmd.ExecuteReader();

            while (re.Read())
            {
                adherants.Add(new Adherant(re.GetInt32("id"), re.GetString("fullname"), re.GetString("cin"), re.GetString("tel"), re.GetString("email")));
            }
            connection.Close();
            return adherants;
        }

        public Adherant findById(int id)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select * from adherant where id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader re = cmd.ExecuteReader();

            if (re.Read())
            {
                Adherant r=new Adherant(re.GetInt32("id"), re.GetString("fullname"), re.GetString("cin"), re.GetString("tel"), re.GetString("email"));
                connection.Close();
                return r;
            }
            connection.Close();
            return null;

        }

        public bool update(Adherant o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "update adherant set fullname=@fullname,cin=@cin,tel=@tel,email=@email where id=@id";

            cmd.Parameters.AddWithValue("@fullname", o.Fullname);
            cmd.Parameters.AddWithValue("@cin", o.Cin);
            cmd.Parameters.AddWithValue("@tel", o.Tel);
            cmd.Parameters.AddWithValue("@email", o.Email);
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
