
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GroundManagmentSystem.Objects
{
     class sprawdzonko
    {
        public void method(bool conn_check=false)
        {
            
            string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=GroundManagmentSystemDataBase;Trusted_Connection=True;";
            string sqlQuery = $"SELECT COUNT(ISA_number) FROM   [GroundManagmentSystemDataBase].[dbo].[ISA_Models]";


            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            con.Open();
            int DB_empty_or_full = (int)sc.ExecuteScalar();
            con.Close();

            if (DB_empty_or_full > 0)
            {
              conn_check = true;
              

            }
            if (DB_empty_or_full <= 0)
            {
                conn_check = false;

            }
            else
            {

                Console.WriteLine("BŁĄD");
            }


        }













    }
    
       
    
}

