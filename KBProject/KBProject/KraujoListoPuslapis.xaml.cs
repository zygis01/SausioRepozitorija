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

namespace KBProject
{
    /// <summary>
    /// Interaction logic for KraujoListoPuslapis.xaml
    /// </summary>
    public partial class KraujoListoPuslapis : Page
    {
        public KraujoListoPuslapis()
        {
            InitializeComponent();
        }

        private void RezervuotiButton_Click(object sender, RoutedEventArgs e)
        {
            //Paziurim kuris yra parinktas ir jo Content paverte i stringa isspausdinam.
            RadioButton pasirinktas = KraujoPanel.Children.OfType<RadioButton>().Where(x => x.IsChecked == true).First();
            string parinktotekstas = pasirinktas.Content.ToString();
            MessageBox.Show($"Jus uzsirezervavote krauja!\n {parinktotekstas}");
        }
    }
}
