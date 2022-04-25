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

namespace getalOmzettenNaarBinair
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(txtInput.Text);
            if (getal <= 255)
            {
                string binary = Convert.ToString(getal, 2);
                lblResult.Content = $"{binary}";
            }
            else
            {
                lblResult.Content = "Niet geldig!";
            }
           
        }
    }
}
