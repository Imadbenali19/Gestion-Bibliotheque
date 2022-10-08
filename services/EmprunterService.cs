using Gestion_Bibliothèque.entities;
using Gestion_Bibliothèque.IDoa;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Bibliothèque.services
{
    class EmprunterService : Idoa<Emprunter>
    {
        private AdherantService ad = new AdherantService();
        private OuvrageService ou = new OuvrageService();

        private MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=;database=gest_biblio");
        public bool create(Emprunter o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "insert into emprunter values(null,@idAdherant,@numOuvrage,@dateDebut,@dateFin,0)";

            cmd.Parameters.AddWithValue("@idAdherant", o.getAdherant().Id);
            cmd.Parameters.AddWithValue("@numOuvrage", o.getOuvrage().Cote);
            cmd.Parameters.AddWithValue("@dateDebut", o.DateDebut);
            cmd.Parameters.AddWithValue("@dateFin", o.DateFin);


            if (cmd.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public bool delete(Emprunter o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "delete from emprunter where id=@id";

            cmd.Parameters.AddWithValue("@id", o.Id);


            if (cmd.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public List<Emprunter> findAll()
        {
            List<Emprunter> emprunter = new List<Emprunter>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select * from emprunter";

            MySqlDataReader re = cmd.ExecuteReader();

            while (re.Read())
            {
                emprunter.Add(new Emprunter(re.GetInt32("id"),ad.findById(re.GetInt32("idAdherant")), ou.findById(re.GetInt32("numOuvrage")), re.GetDateTime("dateDebut").ToString("yyyy-MM-dd"), re.GetDateTime("dateFin").ToString("yyyy-MM-dd"),re.GetInt32("retourne")));
            }
            connection.Close();
            return emprunter;
        }

        public Emprunter findById(int id)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select * from emprunter where id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader re = cmd.ExecuteReader();

            if (re.Read())
            {
                Emprunter E= new Emprunter(re.GetInt32("id"), ad.findById(re.GetInt32("idAdherant")), ou.findById(re.GetInt32("numOuvrage")), re.GetDateTime("dateDebut").ToString("yyyy-MM-dd"), re.GetDateTime("dateFin").ToString("yyyy-MM-dd"), re.GetInt32("retourne"));
                connection.Close();
                return E;
            }
            connection.Close();
            return null;

        }

        public bool update(Emprunter o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "update emprunter set idAdherant=@idAdherant,numOuvrage=@numOuvrage,dateDebut=@dateDebut,dateFin=@dateFin,retourne=@retourne where id=@id";

            cmd.Parameters.AddWithValue("@idAdherant", o.getAdherant().Id);
            cmd.Parameters.AddWithValue("@numOuvrage", o.getOuvrage().Cote);
            cmd.Parameters.AddWithValue("@dateDebut", o.DateDebut);
            cmd.Parameters.AddWithValue("@dateFin", o.DateFin);
            cmd.Parameters.AddWithValue("@retourne", o.Retourne);
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
