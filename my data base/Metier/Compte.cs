using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_data_base.Metier
{
    class Compte
    {
        private int NumCompte;
        private double Montant ;
        private String TypeCompt;
        public int Numclient;
        public Compte()
        {
            this.NumCompte = 0;
            this.Montant = 0;
            this.TypeCompt = null;
            this.Numclient = 0;
        }
        public Compte(int num , double mont, string type )
        {
            this.NumCompte = num;
            this.Montant = mont;
            this.TypeCompt = type;
            this.Numclient = 0;
        }
        public void setNum(int num)
        {
            this.NumCompte = num;
        }
        public void setMont(double mont)
        {
            this.Montant = mont;
        }
        public void setType(string type)
        {
            this.TypeCompt = type;
        }
        public void setNumclient(int numcl)
        {
            this.Numclient = numcl;
        }
        public int getNum() { return this.NumCompte; }
        public double getMont() { return this.Montant; }
        public string gettype() { return this.TypeCompt; }
        public int getNumclient() { return this.Numclient; }
    }
}
