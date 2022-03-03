using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for RegistracijosPuslapis.xaml
    /// </summary>
    public partial class RegistracijosPuslapis : Page
    {
        public RegistracijosPuslapis()
        {
            InitializeComponent();
        }

        private void AmziausDezute_TextChanged(object sender, TextChangedEventArgs e)
        {
            // vartotojas negali ivesti laukelyje raidziu
            if (Regex.IsMatch(AmziausDezute.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Galima ivesti tik skaicius!");
                AmziausDezute.Text = AmziausDezute.Text.Remove(AmziausDezute.Text.Length - 1);
            }
        }

        private void PavardesDezute_TextChanged(object sender, TextChangedEventArgs e)
        {
            // vartotojas negali ivesti laukelyje skaiciu
            if (Regex.IsMatch(PavardesDezute.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Galima ivesti tik raides!");
                PavardesDezute.Text = PavardesDezute.Text.Remove(PavardesDezute.Text.Length - 1);
            }
        }

        private void VardoDezute_TextChanged(object sender, TextChangedEventArgs e)
        {
            // vartotojas negali ivesti laukelyje skaiciu
            if (Regex.IsMatch(VardoDezute.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Galima ivesti tik raides!");
                VardoDezute.Text = VardoDezute.Text.Remove(VardoDezute.Text.Length - 1);
            }
        }
        private void Registruotis_Click(object sender, RoutedEventArgs e)
        {   
            //Papildom duombaze nuspaudus mygtuka Registruotis.
            PapildoDuombaze();
            MessageBox.Show("Sekmingai prisiregistravote! Dabar galite prisijungti.");
        }
        private void PapildoDuombaze()
        {
            //Paziurim kuris radiobutton pazymetas.
            //Tada visus duomenis siunciam i duombaze.
            try
            {
                KBdatabase db = new KBdatabase();
                RadioButton pasirinktas = GrupesPanel.Children.OfType<RadioButton>().Where(x => x.IsChecked == true).First();
                int indeksas = GrupesPanel.Children.IndexOf(pasirinktas);
                db.IDuomenuBaze(VardoDezute.Text, PavardesDezute.Text, Convert.ToInt32(AmziausDezute.Text), indeksas, SlaptazodzioDezute.Password);
                MessageBox.Show("Buvote sekmingai pridetas i duomenu baze");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ivyko klaida papildant duombaze!\n {ex.Message}");
            }
        }
    }
}
