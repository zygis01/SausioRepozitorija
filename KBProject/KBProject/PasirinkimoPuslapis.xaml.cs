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
    /// Interaction logic for PasirinkimoPuslapis.xaml
    /// </summary>
    public partial class PasirinkimoPuslapis : Page
    {
        public PasirinkimoPuslapis()
        {
            InitializeComponent();
        }

        private void AukotiBtn_Click(object sender, RoutedEventArgs e)
        {
            //Laiko trukumas, neapsikrauti ties aukojimu ir nedeti nieko i lista ar duombaze.
            //Prioritetas - veikimas.
            MessageBox.Show("Paimamas jusu kraujas...");
            MessageBox.Show("Jusu kraujas paimtas sekmingai!");
        }

        private void IeskotiBtn_Click(object sender, RoutedEventArgs e)
        {
            //Paspaudus mygtuka Ieskoti naviguojam i kita langa.
            PasirinkimoRemelis.Navigate(new KraujoListoPuslapis());
        }
    }
}
