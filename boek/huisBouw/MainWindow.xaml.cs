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

namespace huisBouw
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
            rect.Height = 100; rect.Width = 100;
            rect.Margin = new Thickness(150, 150, 0, 0);
            rect.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect);

            Line line1 = new Line();
            line1.X1 = 150; line1.Y1 = 150;
            line1.X2 = 200; line1.Y2 = 75;
            line1.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line1);


            Line line2 = new Line();
            line2.X1 = 250; line2.Y1 = 150;
            line2.X2 = 200; line2.Y2 = 75;
            line2.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line2);

            Rectangle rect2 = new Rectangle();
            rect2.Height = 50; rect2.Width = 50;
            rect2.Margin = new Thickness(175, 175, 0, 0);
            rect2.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect2);


            Line line3 = new Line();
            line3.X1 = 175; line3.Y1 = 200;
            line3.X2 = 225; line3.Y2 = 200;
            line3.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line3);

            Line line4 = new Line();
            line4.X1 = 200; line4.Y1 = 175;
            line4.X2 = 200; line4.Y2 = 225;
            line4.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(line4);




        }
    }
}
