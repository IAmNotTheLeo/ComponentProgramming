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

        /*public void CreateEmployeeAccount(int NumberID, String fullName, String address, int phone, DateTime dateJoined)
        {
            SqlConnection myconnection = GetConnection();
            String myquery = "INSERT INTO Employee (NumberID, FullName, EAddress, Phone, DateJoined) VALUES ('" + NumberID + "', '" + fullName + "', '" + address + "', '" + phone + "', '" + dateJoined + "')";
            SqlCommand mycommand = new SqlCommand(myquery, myconnection);

            try
            {
                myconnection.Open();
                mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Exception in DBHandler" + ex);
            }
            finally
            {
                myconnection.Close();

            }

        }*/



    }
}
