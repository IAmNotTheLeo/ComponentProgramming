using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentProgramming
{
    class DBConnection
    {
        private static readonly object padlock = new object();
        private static DBConnection instance = null;

        public static DBConnection GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DBConnection();
                }
                return instance;
            }
        }

        private static SqlConnection GetConnection()
        {
            String directPath = "Data Source=sql-server;Initial Catalog=lc8884l;User ID=lc8884l;Password=!1SQLServer";
            return new SqlConnection(directPath);
        }

        public void CreateEmployeeAccount(int numberID, String firstName, String surname, String address, String email, String password, int departmentID, DateTime dateJoined)
        {
            SqlConnection myconnection = GetConnection();
            String myquery = "INSERT INTO Employee (NumberID, FirstName, Surname, Address, Email, Password, Phone, DepartmentID, DateJoined) VALUES ('@v1', '@v2', '@v3', '@v4', '@v5', '@v6', '@v7', '@v8')";
            SqlCommand mycommand = new SqlCommand(myquery, myconnection);
            mycommand.Parameters.AddWithValue("@v1", numberID);
            mycommand.Parameters.AddWithValue("@v2", firstName);
            mycommand.Parameters.AddWithValue("@v3", surname);
            mycommand.Parameters.AddWithValue("@v4", address);
            mycommand.Parameters.AddWithValue("@v5", email);
            mycommand.Parameters.AddWithValue("@v6", password);
            mycommand.Parameters.AddWithValue("@v7", departmentID);
            mycommand.Parameters.AddWithValue("@v8", dateJoined);

            try
            {
                myconnection.Open();
                mycommand.ExecuteNonQuery();
                Console.WriteLine("Works");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                myconnection.Close();

            }

        }



    }
}
