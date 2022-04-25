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

namespace WpfCircle
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

        private void btnResults_Click(object sender, RoutedEventArgs e)
        {
            paperCanvas.Children.Clear();
            int radius = Convert.ToInt32(txtRadius.Text);
            int d = 2 * radius;
            double circumference = Math.Round( 2 * Math.PI * radius);
            double area = Math.Round(  Math.PI * Math.Pow(radius, 2));
            double volume = Math.Round( (4 * Math.PI / 3) * Math.Pow(radius, 3));

            Ellipse ellipse = new Ellipse();
            ellipse.Width = d; ellipse.Height = 80;
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            ellipse.Margin = new Thickness(70, 70, 0, 0);
            paperCanvas.Children.Add(ellipse);

            rsltLabel.Content = $"De omtrek van deze cirkel is {circumference}, de oppervlakte is {area}, het volume is {volume}.";

        }
    }
}
