using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
    class DBConnection
    { 
        public DBConnection()
        {
        

        }

        /*public void Test()
        {
            SqlConnection myconnection = GetConnection();
            String myquery = "SELECT * FROM EmployeeTable";
            SqlCommand sqlCommand = new SqlCommand(myquery, myconnection);

            try
            {
                myconnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    reader[2].ToString();
                }
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
        

        private static SqlConnection GetConnection()
        {
            String directPath = "Data Source=sql-server;Initial Catalog=lc8884l;User ID=lc8884l;Password=!1SQLServer";
            return new SqlConnection(directPath);
        }
    }
}
