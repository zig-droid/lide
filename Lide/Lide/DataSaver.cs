using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lide
{
    internal class DataSaver
    {
        
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=People;";
        string query = "INSERT INTO Person (FirstName, LastName) VALUES (@firstName, @lastName)";
        public bool SavePeopleData(string firstName, string lastName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))

                    {
                        command.Parameters.Add("@FirstName", System.Data.SqlDbType.NVarChar).Value = firstName;
                        command.Parameters.Add("@LastName", System.Data.SqlDbType.NVarChar).Value = lastName;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "chyba při pokusu k připojení k databázi", MessageBoxButton.OK);

            }
            return true;
        }
    }
}
