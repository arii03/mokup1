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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Welcome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGreat_Click(object sender, RoutedEventArgs e)
        {
            
            string name = txtName.Text;
            string surname = txtSurname.Text;
            var date = Date.SelectedDate;

            if (date > DateTime.Today)
                MessageBox.Show("è impossibile che tu sia nato nel futuro!", "Errore!", MessageBoxButton.OK);
             else if (name == "" || surname == "")
            {
                MessageBox.Show("devi inserire il nome e il cognome", "Errore!", MessageBoxButton.OK);
            } else
                MessageBox.Show($"hello {name} {surname} born the {date.Value.ToShortDateString()}!");

            

        }

        private void Check_Checked(object sender, RoutedEventArgs e)
        {
            btnPrint.IsEnabled = true;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
