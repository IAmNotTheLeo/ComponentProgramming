using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connection
{
    public class DBConnection
    {
        /*private static readonly object padlock = new object();
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
        }*/

        private static SqlConnection GetConnection()
        {
            String directPath = "Data Source=sql-server;Initial Catalog=lc8884l;User ID=lc8884l;Password=!1SQLServer";
            return new SqlConnection(directPath);
        }

        public static void CreateEmployeeAccount()
        {
            SqlConnection myconnection = GetConnection();
            String myquery = "INSERT INTO Employee (FirstName, Surname, Address, Email, Password, Phone, DepartmentID, DateJoined) VALUES ('Leo', 'Chimborazo', '12 Sample Lane', 'bob@gmail.com', '111', '09876543', '1', '20/20/20')";
            SqlCommand mycommand = new SqlCommand(myquery, myconnection);
            try
            {
                myconnection.Open();
                mycommand.ExecuteNonQuery();
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
