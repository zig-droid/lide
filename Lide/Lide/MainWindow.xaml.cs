using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;


namespace Lide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoadData loadData = new LoadData();
        Adrress adrress = new Adrress();
        DataSaver saver = new DataSaver();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            try
            {
                bool success = saver.SavePeopleData(firstName, lastName);
                if (success)
                {
                    MessageBox.Show("Data byla uložena!", "Uloženo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                    MessageBox.Show("Uložení dat selhalo", "Chyba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Chyba při pokusu připojit se k databázi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                loadData.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "chyba při pokusu otevření nového okna", MessageBoxButton.OK);

            }
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba v uzavření okna", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void AdrressButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                adrress.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba při otevírání okna", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
