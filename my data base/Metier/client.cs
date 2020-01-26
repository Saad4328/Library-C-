using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_data_base.Metier
{
    class Client
    {
        private int NumClient;
        private String Nom;
        private String Prenom;
        private String Gsm;
        private String E_mail;
        public Client()
        {
        
        }
        public Client(int num , String nom , String prenom , String gsm, String e_mail)
        {
            this.NumClient = num;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Gsm = gsm;
            this.E_mail = e_mail;
        }
        public void setNum(int num) { this.NumClient = num; }
        public void setNom(String nom)  { this.Nom = nom; }
        public void setPrenom(String prenom) { this.Prenom = prenom; }
        public void setGsm(String gsm) { this.Gsm = gsm; }
        public void setE_mail(String e_mail) { this.E_mail = e_mail; }
        public int getNum(){ return this.NumClient; }
        public string getNom() { return this.Nom; }
        public string getPrenom() { return this.Prenom; }
        public string getGsm() { return this.Gsm; }
        public string getE_mail() { return this.E_mail; }
    }
}
