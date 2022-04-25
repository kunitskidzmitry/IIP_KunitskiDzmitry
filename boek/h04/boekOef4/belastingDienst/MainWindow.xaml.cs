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

namespace belastingDienst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            label1.Visibility = Visibility.Hidden;
            label3.Visibility = Visibility.Hidden;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int procent = 20;
            double inkomsten = Convert.ToDouble(txtInkomen.Text);
            double belastingHouding = (inkomsten * procent) / 100;
            double inkomstenNaBelastingHouding = inkomsten - belastingHouding;

            label1.Visibility = Visibility.Visible;
            label3.Visibility = Visibility.Visible;

            lblBelasting.Content = $"{belastingHouding:c}";
            lblinkomen.Content = $"{inkomstenNaBelastingHouding:c}";




        }
    }
}
