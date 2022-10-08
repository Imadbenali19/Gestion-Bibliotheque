using Gestion_Bibliothèque.entities;
using Gestion_Bibliothèque.IDoa;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Bibliothèque.services
{
    class OuvrageService : Idoa<Ouvrage>
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=;database=gest_biblio");

        public bool create(Ouvrage o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            if (o.Type == "Livre")
            {
                cmd.CommandText = "insert into ouvrage values(null,@auteur,@titre,@editeur,'','','',@type,@quantite)";

                cmd.Parameters.AddWithValue("@auteur", o.Auteur);
                cmd.Parameters.AddWithValue("@titre", o.Titre);
                cmd.Parameters.AddWithValue("@editeur", o.Editeur);
                cmd.Parameters.AddWithValue("@type", o.Type);
                cmd.Parameters.AddWithValue("@quantite", o.Quantite);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
            else if (o.Type == "CD")
            {
                cmd.CommandText = "insert into ouvrage values(null,@auteur,@titre,'','','','',@type,@quantite)";

                cmd.Parameters.AddWithValue("@auteur", o.Auteur);
                cmd.Parameters.AddWithValue("@titre", o.Titre);
                cmd.Parameters.AddWithValue("@type", o.Type);
                cmd.Parameters.AddWithValue("@quantite", o.Quantite);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
            else
            {
                cmd.CommandText = "insert into ouvrage values(null,'','','',@nom,@num,@periodicite,@type,@quantite)";

                cmd.Parameters.AddWithValue("@nom", o.Nom);
                cmd.Parameters.AddWithValue("@num", o.Num);
                cmd.Parameters.AddWithValue("@periodicite", o.Periodicite);
                cmd.Parameters.AddWithValue("@quantite", o.Quantite);
                cmd.Parameters.AddWithValue("@type", o.Type);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
        }

        public bool delete(Ouvrage o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "delete from ouvrage where cote=@cote";

            cmd.Parameters.AddWithValue("@cote", o.Cote);


            if (cmd.ExecuteNonQuery() > 0)
            {
                connection.Close();
                return true;
            }
            connection.Close();
            return false;
        }

        public List<Ouvrage> findAll()
        {
            List<Ouvrage> ouvrages = new List<Ouvrage>();

            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select * from ouvrage";

            MySqlDataReader re = cmd.ExecuteReader();

            while (re.Read())
            {
                ouvrages.Add(new Ouvrage(re.GetInt32("cote"), re.GetString("auteur"), re.GetString("titre"), re.GetString("editeur"), re.GetString("nom"), re.GetString("num"), re.GetString("periodicite"), re.GetString("typeOuvrage"), re.GetInt32("quantite")));
            }
            connection.Close();
            return ouvrages;
        }

        public Ouvrage findById(int id)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select * from ouvrage where cote=@id";
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader re = cmd.ExecuteReader();

            if (re.Read())
            {
                Ouvrage ou=new Ouvrage(re.GetInt32("cote"), re.GetString("auteur"), re.GetString("editeur"), re.GetString("editeur"), re.GetString("nom"), re.GetString("num"), re.GetString("periodicite"), re.GetString("typeOuvrage"), re.GetInt32("quantite"));
                connection.Close();
                return ou;
            }
            connection.Close();
            return null;

        }

        public bool update(Ouvrage o)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();
            if (o.Type=="Livre")
            {
                cmd.CommandText = "update ouvrage set auteur=@auteur,titre=@titre,editeur=@editeur,quantite=@quantite where cote=@cote";

                cmd.Parameters.AddWithValue("@auteur", o.Auteur);
                cmd.Parameters.AddWithValue("@titre", o.Titre);
                cmd.Parameters.AddWithValue("@editeur", o.Editeur);
                cmd.Parameters.AddWithValue("@cote",o.Cote);
                cmd.Parameters.AddWithValue("@quantite", o.Quantite);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
            else if (o.Type == "CD")
            {
                cmd.CommandText = "update ouvrage set auteur=@auteur,titre=@titre,quantite=@quantite where cote=@cote";

                cmd.Parameters.AddWithValue("@auteur", o.Auteur);
                cmd.Parameters.AddWithValue("@titre", o.Titre);
                cmd.Parameters.AddWithValue("@cote", o.Cote);
                cmd.Parameters.AddWithValue("@quantite", o.Quantite);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
            else
            {
                cmd.CommandText = "update ouvrage set nom=@nom,num=@num,periodicite=@periodicite,quantite=@quantite where cote=@cote";

                cmd.Parameters.AddWithValue("@nom", o.Nom);
                cmd.Parameters.AddWithValue("@num", o.Num);
                cmd.Parameters.AddWithValue("@periodicite", o.Periodicite);
                cmd.Parameters.AddWithValue("@cote", o.Cote);
                cmd.Parameters.AddWithValue("@quantite", o.Quantite);


                if (cmd.ExecuteNonQuery() > 0)
                {
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
            
        }

        public bool emprunter(int id)
        {
            connection.Open();

            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "select count(*) as nb from emprunter em where idAdherant=@id and retourne=0 and DATEDIFF(dateDebut, now()) BETWEEN 0 and 7 ";

            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader re = cmd.ExecuteReader();

            if (re.Read())
            {
                if (re.GetInt32("nb") < 3)
                {
                    connection.Close();
                    return true;
                }
                
            }
            connection.Close();
            return false;
        }
    }
}
