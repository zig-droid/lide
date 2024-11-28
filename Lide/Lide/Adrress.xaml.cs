using System;
using System.Collections.Generic;
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
    /// Interaction logic for Adrress.xaml
    /// </summary>
    public partial class Adrress : Window
    {
        public Adrress()
        {
            InitializeComponent();
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
    }
}
