using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace KBProject
{
    /// <summary>
    /// Interaction logic for PrisijungimoPuslapis.xaml
    /// </summary>
    public partial class PrisijungimoPuslapis : Page
    {
        public PrisijungimoPuslapis()
        {
            InitializeComponent();
        }
        private void VardoDezute_TextChanged(object sender, TextChangedEventArgs e)
        {
            // vartotojas negali ivesti laukelyje skaiciu
            try
            {
                if (Regex.IsMatch(VardoDezute.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Galima ivesti tik raides!");
                    VardoDezute.Text = VardoDezute.Text.Remove(VardoDezute.Text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ivyko klaida vardo laukelyje!\n {ex.Message}");
            }
            
        }

        private void ParodytiCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            //Jeigu checkbox yra uzzymetas, parodom slaptazodi.
            slaptazodzioTextBox.Text = SlaptazodzioDezute.Password;
            SlaptazodzioDezute.Visibility = Visibility.Collapsed;
            slaptazodzioTextBox.Visibility = Visibility.Visible;
        }

        private void ParodytiCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            //Jeigu checkbox yra neuzzymetas, nerodom slaptazodzio.
            SlaptazodzioDezute.Password = slaptazodzioTextBox.Text;
            slaptazodzioTextBox.Visibility = Visibility.Collapsed;
            SlaptazodzioDezute.Visibility = Visibility.Visible;
        }
        private void Prisijungti_Click(object sender, RoutedEventArgs e)
        {
            KBdatabase database = new KBdatabase();
            database.NuskaitomDuombaze(VardoDezute.Text, SlaptazodzioDezute.Password);
            PrisijungimoRemelis.Navigate(new PasirinkimoPuslapis());
        }
    }
}
