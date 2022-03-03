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
using System.Xaml.Permissions;

namespace KBProject
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
        private void Registracija_Click(object sender, RoutedEventArgs e)
        {
            // paspaudus mygtuka nuvedame i registracijos psl.
            RegistracijosPuslapis regPuslapis = new RegistracijosPuslapis();
            MainRemelis.Navigate(regPuslapis);
        }
        private void Prisijungimas_Click(object sender, RoutedEventArgs e)
        {
            PrisijungimoPuslapis prisPuslapis = new PrisijungimoPuslapis();
            MainRemelis.Navigate(prisPuslapis);
        }
    }
}
