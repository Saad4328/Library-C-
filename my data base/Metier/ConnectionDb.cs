using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace my_data_base.Metier
{
    class ConnectionDb
    {
        public string connexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + "C:\\Users\\AMDMT\\source\\my data base\\my data base\\Metier\\gestion_des_compte.mdf"+"; Integrated Security=True;";
        public static SqlConnection conan;
        public void connection_todo()
        {
            conan = new SqlConnection(connexion);
           
            conan.Open();
            
            //SqlCommand comm = new SqlCommand();
            //comm.Connection = conan;
           // comm.CommandText = "INSERT INTO [dbo].[Compte] VALUES ('"++"','"++"')";
            //comm.ExecuteNonQuery();
        }

        public static void Ajouter(Compte C, Client C1)
        {
            
            SqlCommand comm = new SqlCommand();
            SqlCommand comm2 = new SqlCommand();
            comm.Connection = conan;
            comm2.Connection = conan;
            comm.CommandText = "INSERT INTO[dbo].[Compte]([NumCompte], [Montant], [TypeCompt], [Numclient]) VALUES("+C.getNum()+", "+C.getMont()+",'"+C.gettype()+"',"+C1.getNum()+")";
            comm2.CommandText = "INSERT INTO[dbo].[Client]([NumClient], [Nom], [Prenom], [Gsm], [E_mail]) VALUES("+C1.getNum()+",'"+C1.getNom()+"','"+C1.getPrenom()+"','" +C1.getGsm()+"','"+C1.getE_mail()+"')";


            //comm.CommandText = "INSERT INTO `compte`(`NumCompte`, `Montant`, `TypeCompt`, `Numclient`) VALUES ("C.getNum+","C.getMont ","C.gettype","C1.getNum")";

            comm.ExecuteNonQuery();
            comm2.ExecuteNonQuery();
        }
        public static void saerchcompte(Compte V,int b)
        {
            V.setNum(b);
            //UPDATE `compte` SET `Montant`=1234,`TypeCompt`='hello',`Numclient`=123 WHERE `NumCompte`=1
            SqlCommand comm2 = new SqlCommand();
            
            comm2.Connection = conan;
            comm2.CommandText = "SELECT [Montant] FROM[dbo].[Compte] WHERE[NumCompte] = "+V.getNum()+"";
            //comm2.CommandText = "SELECT * FROM[dbo].[Compte] WHERE[NumCompte] = 432879";
            //V=(Compte)comm2.ExecuteScalar();
            
            V.setMont((double)comm2.ExecuteScalar());

            Console.WriteLine(V.getMont());
            





        }
        public static void Vesement(Compte A)
        {
            SqlCommand comm2 = new SqlCommand();
            comm2.Connection = conan;
            comm2.CommandText = "UPDATE [dbo].[Compte] SET [Montant]="+A.getMont()+" WHERE [NumCompte]="+ A.getNum()+"";
            comm2.ExecuteScalar();
        }
        public static void insertOper(int i, string s)
        {
            SqlCommand comm2 = new SqlCommand();
            comm2.Connection = conan;

            comm2.CommandText = "INSERT INTO [dbo].[Operation] ( [Type], [Date], [numCompte]) VALUES ('"+s+"', '"+null+"', "+i+")";
            comm2.ExecuteScalar();
        }

    }
}
