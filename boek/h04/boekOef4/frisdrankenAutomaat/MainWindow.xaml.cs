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

namespace frisdrankenAutomaat
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int price = 0;
        public MainWindow()
        {
            InitializeComponent();
            lblColaPrice.Content = $"{0.45:c}";
            lblFantaPrice.Content = $"{0.75:c}";
            lblPriceSprite.Content = $"{1.25:c}";
            txtMuntStukken.Visibility = Visibility.Hidden;
            labelMunt.Visibility = Visibility.Hidden;
            btnKlaar.Visibility = Visibility.Hidden;
        }

        private void imageCoca_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtMuntStukken.Visibility = Visibility.Visible;
            labelMunt.Visibility = Visibility.Visible;
            btnKlaar.Visibility = Visibility.Visible;
            price = 45;
            lblKeuze.Content = $"2. Kostprijs: {lblColaPrice.Content}";

        }
     

        private void btnKlaar_Click(object sender, RoutedEventArgs e)
        {

            int amountGiven = Convert.ToInt32(txtMuntStukken.Text);
            int wisselgeld = amountGiven - price;
           
            int twoEuro = wisselgeld / 200;
            int oneEuro = (wisselgeld % 200)/100;
            int fifty = ((wisselgeld % 200) % 100)/50;
            int twinty = (((wisselgeld % 200) % 100) % 50)/20;
            int ten = ((((wisselgeld % 200) % 100) % 50) % 20)/10;
            int five = (((((wisselgeld % 200) % 100) % 50)% 20)% 10)/5;
            int two = ((((((wisselgeld % 200) % 100) % 50) % 20) % 10)%5)/2;
            int one = (((((((wisselgeld % 200) % 100) % 50) % 20) % 10) % 5)% 2)/1;
            NumberTwoEuro.Content = $"Number of 2 euro coins is {twoEuro}";
            NumberOneEuro.Content = $"Number of 1 euro coins is {oneEuro}";
            NumberFiftyCent.Content = $"Number of 50 cent coins is {fifty}";
            NumberTwintyCent.Content = $"Number of 20 cent coins is {twinty}";
            NumberTenCent.Content = $"Number of 10 cent coins is {ten}";
            NumberfiveCent.Content = $"Number of 5 cent coins is {five}";
            NumberTwoyCent.Content = $"Number of 2 cent coins is {two}";
            NumberOneCent.Content = $"Number of 1 cent coins is {one}";
            lblChange.Content = $"Terug bezorgen: {wisselgeld} cents.";
            txtMuntStukken.Text = "";






        }

        private void imageSprite_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtMuntStukken.Visibility = Visibility.Visible;
            labelMunt.Visibility = Visibility.Visible;
            btnKlaar.Visibility = Visibility.Visible;
            price = 125;
            lblKeuze.Content = $"2. Kostprijs: {lblPriceSprite.Content}";
           
        }

        private void imageFanta_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtMuntStukken.Visibility = Visibility.Visible;
            labelMunt.Visibility = Visibility.Visible;
            btnKlaar.Visibility = Visibility.Visible;
            price = 75;
            lblKeuze.Content = $"2. Kostprijs: {lblFantaPrice.Content}";
        }
    }
}
