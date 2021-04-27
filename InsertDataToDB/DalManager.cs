using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertDataToDB
{
    class DalManager
    {
        private static string cs = @"Server=ZBC-E-RO-23239\MSSQLSERVER01;Database=ERD_TestDB;Trusted_Connection=True;";

        public void InsertData()
        {
            //string insertData = "insert into random (ID, RandomNumber) Values (@ID, @RandomNumber)";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                Random random = new Random();
                //Add numbers
                for (int i = 1; i <= 1000000; i++)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Random (ID, RandomNumber) VALUES (@ID, @RandomNumber)", connection);
                    int randomNumber = random.Next(0, 9999);
                    cmd.Parameters.Add(new SqlParameter("@ID", i));
                    cmd.Parameters.Add(new SqlParameter("@RandomNumber", randomNumber));
                    Console.WriteLine($"{i}, {randomNumber}");
                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Insert done!!");
            }
        }
    }
}
