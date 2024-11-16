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
using System.Xml.Schema;

namespace Mastermind_WPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            titleRandomColors();
        }

        private void titleRandomColors()
        {
            // alle kleuren
            string[] colors = { "Rood", "Geel", "Oranje", "Wit", "Groen", "Blauw" };
            Random random = new Random();

            // StringBuilder voor tietel
            StringBuilder titleBuilder = new StringBuilder("Mastermind kleur: ");

            // Willekeurige kleuren selecteren
            for (int i = 0; i < 4; i++)
            {
                int randomIndex = random.Next(0, colors.Length);
                titleBuilder.Append(colors[randomIndex]);

                // Voeg een komma en spatie toe behalve na de laatste kleur
                if (i < 3)
                {
                    titleBuilder.Append(", ");
                }
            }

            // Stel de titel van het venster in
            this.Title = titleBuilder.ToString();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox1.SelectedItem is ComboBoxItem ComboBox1Item)  // als item is geselecteerd
            {
                if (ComboBox1Item.Background is SolidColorBrush Kleur) // dan: kleur borstel naar achtergrondskleur van geselecteerde Item
                { 
                    label1.Background = Kleur;   //label de keur geven van achtergrondskleur van geselecteerde Item  
                }
            }
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox2.SelectedItem is ComboBoxItem ComboBox2Item) 
            {
                if (ComboBox2Item.Background is SolidColorBrush Kleur) 
                {
                    label2.Background = Kleur;   
                }
            }
        }

        private void ComboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox3.SelectedItem is ComboBoxItem ComboBox3Item) 
            {
                if (ComboBox3Item.Background is SolidColorBrush Kleur) 
                {
                    label3.Background = Kleur;   
                }
            }
        }

        private void ComboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox4.SelectedItem is ComboBoxItem ComboBox4Item) 
            {
                if (ComboBox4Item.Background is SolidColorBrush Kleur) 
                {
                    label4.Background = Kleur;   
                }
            }
        }
    }
}
