using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Bibliothèque.entities
{
    class Emprunter
    {
        private int id;
        private Adherant ad;
        private Ouvrage ou;
        private string dateDebut;
        private string dateFin;
        private int retourne;

        public Emprunter(Adherant ad, Ouvrage ou, string dateDebut, string dateFin, int retourne)
        {
            this.ad = ad;
            this.ou = ou;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.retourne = retourne;
        }

        public Emprunter(int id, Adherant ad, Ouvrage ou, string dateDebut, string dateFin, int retourne)
        {
            this.id = id;
            this.ad = ad;
            this.ou = ou;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.retourne = retourne;
        }

        public int Id { get => id; set => id = value; }
        public string DateDebut { get => dateDebut; set => dateDebut = value; }
        public string DateFin { get => dateFin; set => dateFin = value; }
        public int Retourne { get => retourne; set => retourne = value; }
        
        public Adherant getAdherant()
        {
            return ad;
        }

        public void setAdherant(Adherant x)
        {
            ad = x;
        }

        public Ouvrage getOuvrage()
        {
            return ou;
        }

        public void setOuvrage(Ouvrage x)
        {
            ou = x;
        }

        public string toString()
        {
            return "Adherant : " + ad + " l'ouvrage : " + ou + " date de debut : " + dateDebut + " date de fin : " + dateFin+ " retourne : "+retourne;
        }

    }
}
