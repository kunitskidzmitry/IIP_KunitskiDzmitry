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

namespace hourMinutesSeconds
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

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            int totalNumberSeconds = Convert.ToInt32(txtShow.Text);
            int uur = totalNumberSeconds / 3600;
            int minuten = totalNumberSeconds / 60;
            int seconden = totalNumberSeconds % 60;
            lblResults.Content = $"H:{uur} M:{minuten} S:{seconden}";
        }
    }
}
