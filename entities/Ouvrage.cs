using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Bibliothèque.entities
{
    class Ouvrage
    {
        private int cote;
        //private string dateEmprunt=null;
        private string auteur;
        private string titre;
        private string editeur;
        private string nom;
        private string num;
        private string periodicite;
        private string type;
        private int quantite;

        public Ouvrage(int cote,string auteur, string titre, string editeur, string nom, string num, string periodicite,string type,int quantite)
        {
            this.cote = cote;
            //this.dateEmprunt = dateEmprunt;
            this.auteur = auteur;
            this.titre = titre;
            this.editeur = editeur;
            this.nom = nom;
            this.num = num;
            this.periodicite = periodicite;
            this.type = type;
            this.quantite = quantite;
        }

        public Ouvrage( string auteur,string titre, string editeur, string nom, string num, string periodicite,string type,int quantite)
        {
            this.auteur = auteur;
            //this.dateEmprunt = dateEmprunt;
            this.titre = titre;
            this.editeur = editeur;
            this.nom = nom;
            this.num = num;
            this.periodicite = periodicite;
            this.type = type;
            this.quantite = quantite;
        }

        public int Cote { get => cote; set => cote = value; }
        //public string DateEmprunt { get => dateEmprunt; set => dateEmprunt = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Editeur { get => editeur; set => editeur = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Num { get => num; set => num = value; }
        public string Periodicite { get => periodicite; set => periodicite = value; }
        public string Type { get => type; set => type = value; }
        public int Quantite { get => quantite; set => quantite = value; }

        public string toString()
        {
            if (this.Type == "Livre")
            {
                return "Cote : " + this.Cote + " Type "+ this.Type+ " Auteur "+this.Auteur+" Titre "+this.Titre+" Editeur "+this.Editeur+" quantite : "+this.Quantite;
            }
            else if (this.Type == "CD")
            {
                return "Cote : " + this.Cote + " Type " + this.Type +" Auteur " + this.Auteur + " Titre " + this.Titre + " quantite : " + this.Quantite;
            }
            else
            {
                return "Cote : " + this.Cote + " Type " + this.Type + " Nom " + this.Nom + " Numero " + this.Num + " Periodicite " + this.Periodicite + " quantite : " + this.Quantite;
            }
        }


    }
}
