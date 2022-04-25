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

namespace bankrekening
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

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double beginSaldo = Convert.ToDouble(txtBeginSaldo.Text);
            int yaren = Convert.ToInt32(txtAantaalYaren.Text);
            double rente = Convert.ToDouble(txtRente.Text);

            double result = beginSaldo * Math.Pow(1 + (rente/100), yaren);
            lblResult.Content = $"{result}";
        }
    }
}
