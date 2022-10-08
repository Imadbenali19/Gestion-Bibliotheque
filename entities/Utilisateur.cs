using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Bibliothèque.entities
{
    class Utilisateur
    {
        private int id;
        private string login;
        private string password;
        private int isAdmin;

        public Utilisateur(string login, string password, int isAdmin)
        {
            this.login = login;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public Utilisateur(int id, string login, string password, int isAdmin)
        {
            this.id = id;
            this.login = login;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int IsAdmin { get => isAdmin; set => isAdmin = value; }



        /*public bool emprunter(Bibliotheque b,string nom,string dateFin)
        {
            Periodique p = null;
            
            for (int i = 0; i < b.Position; i++)
            {
                if (b.Ouvrages[i].GetType() == typeof(Livre) || b.Ouvrages[i].GetType() == typeof(Cd))
                {
                    if (b.Ouvrages[i].Titre == nom && b.Ouvrages[i].DateEmprunt == null)
                    {
                        DateTime now = DateTime.Now;
                        b.Ouvrages[i].DateEmprunt = now.ToString();
                        Emprunter em = new Emprunter(id, b.Ouvrages[i].Cote, now.ToString(), dateFin);
                        return true;
                    }
                }
                else
                {
                    p = (Periodique)b.Ouvrages[i];
                    if (p.Nom == nom && p.DateEmprunt == null)
                    {
                        DateTime now = DateTime.Now;
                        p.DateEmprunt = now.ToString();
                        Emprunter em = new Emprunter(id, p.Cote, now.ToString(), dateFin);
                        return true;
                    }
                }
                    
            }

            return false;
        }*/


        public string toSting()
        {
            return "Login : " + login + " IsAdmin : " + isAdmin;
        }
    }
}
