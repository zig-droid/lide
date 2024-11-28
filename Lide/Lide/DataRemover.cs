using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;
using System.IO;


namespace Lide
{
    internal class DataRemover
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=People;";
        string query = "DELETE FROM Person WHERE FirstName = @FirstName AND LastName = @LastName";
        public bool RemovePersonByName(string firstName, string lastName)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand  command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.ExecuteNonQuery();
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "chyba při pokusu k připojení k databázi", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            return true;
        }
    }
}
