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

namespace DrawCircle
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
       
        private void DrawingCircle(Canvas drawingCanvas, SolidColorBrush brush, double xCentre, double yCentre, double radius )
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 2 * radius; ellipse.Height = 2 * radius;
            ellipse.Stroke = brush;
            ellipse.Margin = new Thickness(xCentre, yCentre, 0, 0);
            drawingCanvas.Children.Add(ellipse);

        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            paperCanvas.Children.Clear();
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double r = Convert.ToDouble(txtR.Text);
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            DrawingCircle(paperCanvas, brush, x, y, r);

        }
    }
}
