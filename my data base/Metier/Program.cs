using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace my_data_base.Metier
{
    class Program
    {
        static MySqlConnection conn;
        static void Main(string[] args)
        {
            ConnectionDb nnn = new ConnectionDb();
            try
            {
                nnn.connection_todo();
                Console.WriteLine("opened");

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            /*
             Console.WriteLine("Getting Connection ...");
             conn = DBUtils.GetDBConnection();
             try
             {
                 Console.WriteLine("Openning Connection ...");
                 conn.Open();
                 Console.WriteLine("Connection successful!");
             }
             catch (Exception e)
             {
                 Console.WriteLine("Error: " + e.Message);
             } */
            Operation Opre = new Operation();
            //MySqlCommand comm = new MySqlCommand();
            //comm.Connection =conn;
            //comm.CommandText = "INSERT INTO `test`(`test`) VALUES('help2')";
            //comm.ExecuteNonQuery();
            string point="10";
             while(point!="0")
            {
                Operation.preMenu(point);
               point=Console.ReadLine();
                if (point =="1")
                {
                    Operation.Ajouter();
                }
                else if(point=="2")
                {
                    Operation.deeuMenu();
                }
                


            }
           
   
        }
    }
}
