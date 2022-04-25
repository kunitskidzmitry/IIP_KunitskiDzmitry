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

namespace WpfDemoRandom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int vorigegetal = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random getal = new Random();
            int randomGetal = getal.Next(1, 20);
            lbnMessage.Content = randomGetal + $"(Vorige random getal: {vorigegetal})";
            vorigegetal = randomGetal;
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            Button clikedButton = (Button) sender;
            lbnMessage.Content = clikedButton.Content;
        }
    }
}
 