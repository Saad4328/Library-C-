using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_data_base.Metier
{
    class Operation
    {
        private int idOperation;
        private string Type;
        private DateTime Date;
        private string numCompte;

        public static void preMenu(string P)
        {

            Console.Clear();         
            Console.WriteLine(" 1 Ajouter un compte ");
            Console.WriteLine(" 2 faire une operation ");
            Console.WriteLine(" 0 quiter ");
        }
        static Compte AjCmp = new Compte();
        static Client AjCli = new Client();
        static Compte Cmp = new Compte();
        public static void Ajouter()
        {

            Console.Clear();
            Console.WriteLine("==> entrer le numero de client ");
            AjCli.setNum(int.Parse(Console.ReadLine()));
            AjCmp.setNumclient(AjCli.getNum());
            Console.WriteLine("==> entrer le nom ");
            AjCli.setNom(Console.ReadLine());
            Console.WriteLine("==> entrer le prenom ");
            AjCli.setPrenom(Console.ReadLine());
            Console.WriteLine("==> entrer le numero de GSM ");
            AjCli.setGsm(Console.ReadLine());
            Console.WriteLine("==> entrer E_mail ");
            AjCli.setE_mail(Console.ReadLine());
            Console.WriteLine("==> entrer le numero de compte ");
            AjCmp.setNum(int.Parse(Console.ReadLine()));
            Console.WriteLine("==> entrer le solde");
            AjCmp.setMont(float.Parse(Console.ReadLine()));
            Console.WriteLine("==> entrer le type ( courant/epargne)");
            AjCmp.setType(Console.ReadLine());
            ConnectionDb.Ajouter(AjCmp, AjCli);
            AjCmp = new Compte();
            AjCli = new Client();
        }
        public static void deeuMenu()
        {
            Console.Clear();
            int b = 0;
            Console.WriteLine("entrer le numero de compte(taper 0 pour annuller) :");
            b = int.Parse(Console.ReadLine());
            if (b == 0)
            {

            }
            else if (b != 0)
            {
                DeeuMenu(b);

                int p = 0;
                //Console.WriteLine("");
                OperMenu();
                p = int.Parse(Console.ReadLine());


                if (p == 1)
                {
                    Console.WriteLine("entrer  un solde pour verser :");
                    double S1 = double.Parse(Console.ReadLine());
                    
                        S1 += AjCmp.getMont();
                        AjCmp.setMont(S1);
                        //Console.WriteLine(AjCmp.getNum()+"    "+AjCmp.getMont());
                        ConnectionDb.Vesement(AjCmp);
                        ConnectionDb.insertOper(AjCmp.getNum(), "versement");
                        AjCmp = new Compte();
                   
                    

                }
                else if (p == 2)
                {
                    Console.Clear();
                    int b1 = 0;
                    Console.WriteLine(" entrer le numero de compte de reception ");
                    b1 = int.Parse(Console.ReadLine());
                    ConnectionDb.saerchcompte(Cmp, b1);
                    
                    Console.WriteLine("entrer un solde : ");
                    double S2=double.Parse(Console.ReadLine());
                    if (S2 <= AjCmp.getMont()+100)
                    {
                        AjCmp.setMont(AjCmp.getMont() - S2);
                        Cmp.setMont(Cmp.getMont() + S2);
                        ConnectionDb.Vesement(AjCmp);
                        ConnectionDb.Vesement(Cmp);
                        ConnectionDb.insertOper(AjCmp.getNum(), "Trensfaire");

                        AjCmp = new Compte();
                        Cmp = new Compte();
                    }
                    else
                    {
                        AjCmp = new Compte();
                        imposible();
                        //Console.WriteLine("imposiple de faire cette operation");
                       
                    }




                }
                else if (p == 3)
                {
                    Console.WriteLine("entrer  un solde pour retrer :");
                    double S3 = double.Parse(Console.ReadLine());
                    if (S3 <= AjCmp.getMont())
                    {
                        S3 = AjCmp.getMont() - S3;
                        AjCmp.setMont(S3);
                        ConnectionDb.Vesement(AjCmp);
                        ConnectionDb.insertOper(AjCmp.getNum(), "retretement");
                        AjCmp = new Compte();
                    }
                   
                     else
                        {
                        AjCmp = new Compte();
                        imposible();
                           
                        }
                    
                }

            }
           
        }
        public static void imposible()
        {
            Console.WriteLine("imposiple de faire cette operation entrer 0 pour annuller ");
            int r = int.Parse(Console.ReadLine());


        }
        public static void DeeuMenu(int b)
        {

            ConnectionDb.saerchcompte(AjCmp, b);

        }
        public static void OperMenu()
        {
            Console.Clear();
            Console.WriteLine(" 1 pour verser ");
            Console.WriteLine(" 2 pour transfirer ");
            Console.WriteLine(" 3 pour retrer ");

        }



    }

   

}
