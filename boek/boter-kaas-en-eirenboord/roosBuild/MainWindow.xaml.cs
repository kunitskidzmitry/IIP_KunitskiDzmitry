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

namespace roosBuild
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle rect = new Rectangle();
            rect.Width = 10; rect.Height = 200;
            rect.Margin = new Thickness(375, 300, 0, 0);
            rect.Stroke = new SolidColorBrush(Colors.Black);
            rect.Fill = new SolidColorBrush(Colors.Green);
            paperCanvas.Children.Add(rect);

            Ellipse ellip = new Ellipse();
            ellip.Width = 20; ellip.Height = 20;
            ellip.Margin = new Thickness(370, 285, 0, 0);
            ellip.Stroke = new SolidColorBrush(Colors.Black);
            ellip.Fill = new SolidColorBrush(Colors.Yellow);
            paperCanvas.Children.Add(ellip);

            Ellipse ellip1 = new Ellipse();
            ellip1.Width = 40; ellip1.Height = 70;
            ellip1.Margin = new Thickness(380, 290, 0, 0);
            ellip1.Stroke = new SolidColorBrush(Colors.Black);
            ellip1.Fill = new SolidColorBrush(Colors.Red);
            ellip1.RenderTransform = new RotateTransform(120);
            paperCanvas.Children.Add(ellip1);

            Ellipse ellip2 = new Ellipse();
            ellip2.Width = 40; ellip2.Height = 70;
            ellip2.Margin = new Thickness(400, 270, 0, 0);
            ellip2.Stroke = new SolidColorBrush(Colors.Black);
            ellip2.Fill = new SolidColorBrush(Colors.Pink);
            ellip2.RenderTransform = new RotateTransform(120);
            paperCanvas.Children.Add(ellip2);

        }
    }
}
