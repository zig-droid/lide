using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Lide
{
    internal class DataLoader
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=People;";
        public string LoadPeopleData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT FirstName, LastName FROM Person";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            stringBuilder.AppendLine(firstName + " " + lastName);
                        }

                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Chyba při načítání dat z databáze", MessageBoxButton.OK);
            }
            return stringBuilder.ToString();
        }
    }
}
