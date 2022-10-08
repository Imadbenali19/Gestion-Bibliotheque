using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Bibliothèque.entities
{
    class Adherant
    {
        private int id;
        private string cin;
        private string tel;
        private string fullname;
        private string email;
        

        public Adherant(int id, string fullname, string cin, string tel, string email)
        {
            this.Id = id;
            this.tel = tel;
            this.fullname = fullname;
            this.cin = cin;
            this.Email = email;
        }

        public Adherant(string fullname, string cin, string tel, string email)
        {
            this.cin = cin;
            this.tel = tel;
            this.fullname = fullname;
            this.email = email;
        }

        public string Cin { get => cin; set => cin = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }


        public string toSting()
        {
            return "FullName : " + fullname + " CIN : " + cin + " Tel " + tel + " email : " + Email + " ";
        }
    }
}
