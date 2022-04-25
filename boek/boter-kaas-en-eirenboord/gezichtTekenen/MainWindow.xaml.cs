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

namespace gezichtTekenen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 200; ellipse.Height = 200;
            ellipse.Margin = new Thickness(232,85,0,0);
            ellipse.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipse);

            Ellipse ellipseOog1 = new Ellipse();
            ellipseOog1.Width = 40; ellipseOog1.Height = 40;
            ellipseOog1.Margin = new Thickness(260, 150, 0, 0);
            ellipseOog1.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipseOog1);


            Ellipse ellipseOog2 = new Ellipse();
            ellipseOog2.Width = 40; ellipseOog2.Height = 40;
            ellipseOog2.Margin = new Thickness(360, 150, 0, 0);
            ellipseOog2.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipseOog2);

            Ellipse ellipseOog3 = new Ellipse();
            ellipseOog3.Width = 20; ellipseOog3.Height = 20;
            ellipseOog3.Margin = new Thickness(270, 160, 0, 0);
            ellipseOog3.Stroke = new SolidColorBrush(Colors.Black);
            ellipseOog3.Fill = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipseOog3);


            Ellipse ellipseOog4 = new Ellipse();
            ellipseOog4.Width = 20; ellipseOog4.Height = 20;
            ellipseOog4.Margin = new Thickness(370, 160, 0, 0);
            ellipseOog4.Stroke = new SolidColorBrush(Colors.Black);
            ellipseOog4.Fill = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipseOog4);

            Ellipse ellipseLips = new Ellipse();
            ellipseLips.Width = 90; ellipseLips.Height = 30;
            ellipseLips.Margin = new Thickness(285, 220, 0, 0);
            ellipseLips.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipseLips);

            Ellipse ellipseOor1 = new Ellipse();
            ellipseOor1.Width = 50; ellipseOor1.Height = 90;
            ellipseOor1.Margin = new Thickness(410, 140, 0, 0);
            ellipseOor1.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipseOor1);

            Ellipse ellipseOor2 = new Ellipse();
            ellipseOor2.Width = 50; ellipseOor2.Height = 90;
            ellipseOor2.Margin = new Thickness(200, 140, 0, 0);
            ellipseOor2.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(ellipseOor2);

            Line line1 = new Line();
            line1.X1 = 287; line1.Y1 = 235;
            line1.X2 = 373; line1.Y2 = 235;
            line1.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line1);

            Line line2 = new Line();
            line2.X1 = 330; line2.Y1 = 170;
            line2.X2 = 330; line2.Y2 = 200;
            line2.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line2);

            Line line3 = new Line();
            line3.X1 = 330; line3.Y1 = 200;
            line3.X2 = 350; line3.Y2 = 200;
            line3.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line3);

            Line line4 = new Line();
            line4.X1 = 260; line4.Y1 = 120;
            line4.X2 = 220; line4.Y2 = 80;
            line4.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line4);

            Line line5 = new Line();
            line5.X1 = 290; line5.Y1 = 96;
            line5.X2 = 250; line5.Y2 = 77;
            line5.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line5);

            Line line6 = new Line();
            line6.X1 = 300; line6.Y1 = 90;
            line6.X2 = 380; line6.Y2 = 70;
            line6.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line6);



        }
    }
}
