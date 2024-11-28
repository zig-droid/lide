using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lide
{
    /// <summary>
    /// Interaction logic for LoadData.xaml
    /// </summary>
    public partial class LoadData : Window
    {
        DataLoader loader = new DataLoader();
        DataRemover delete = new DataRemover();
        public LoadData()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBlock.Text = loader.LoadPeopleData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Chyba při načítání dat", MessageBoxButton.OK);
            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba v uzavření okna", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            try
            {
                bool success = delete.RemovePersonByName(firstName, lastName);
                if (success)
                {
                    MessageBox.Show("Osoba byla úspěšně odstraněna", "Smazáno", MessageBoxButton.OK, MessageBoxImage.Information);

                }
                else
                    MessageBox.Show("Osoba nebyla nalezena", "Chyba", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba k připojení k databázi" ,MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba k připojení k databázi", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
