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

namespace regenVal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Rectangle rect1 = new Rectangle();
            rect1.Width = 200; rect1.Height = 25;
            rect1.Margin = new Thickness(0, 0, 0, 0);
            rect1.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect1);

            Rectangle rect2 = new Rectangle();
            rect2.Width = 200; rect2.Height = 25;
            rect2.Margin = new Thickness(200, 0, 0, 0);
            rect2.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect2);

            Rectangle rect3 = new Rectangle();
            rect3.Width = 200; rect3.Height = 25;
            rect3.Margin = new Thickness(200, 25, 0, 0);
            rect3.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect3);

            Rectangle rect4 = new Rectangle();
            rect4.Width = 200; rect4.Height = 25;
            rect4.Margin = new Thickness(0, 50, 0, 0);
            rect4.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect4);

            Rectangle rect5 = new Rectangle();
            rect5.Width = 200; rect5.Height = 25;
            rect5.Margin = new Thickness(200, 50, 0, 0);
            rect5.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect5);

            Rectangle rect6 = new Rectangle();
            rect6.Width = 200; rect6.Height = 25;
            rect6.Margin = new Thickness(0, 75, 0, 0);
            rect6.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect6);

            Rectangle rect7 = new Rectangle();
            rect7.Width = 200; rect7.Height = 25;
            rect7.Margin = new Thickness(200, 75, 0, 0);
            rect7.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect7);

            Rectangle rect8 = new Rectangle();
            rect8.Width = 200; rect8.Height = 25;
            rect8.Margin = new Thickness(0, 25, 0, 0);
            rect8.Stroke = new SolidColorBrush(Colors.Black);
            paperCanvas.Children.Add(rect8);

            Label lab1 = new Label();
            lab1.Margin = new Thickness(0, 0, 0, 0);
            lab1.Width = 200; lab1.Height = 25;
            lab1.Content = "2009";
            paperCanvas.Children.Add(lab1);

            Label lab2 = new Label();
            lab2.Margin = new Thickness(0, 25, 0, 0);
            lab2.Width = 200; lab2.Height = 25;
            lab2.Content = "2010";
            paperCanvas.Children.Add(lab2);

            Label lab3 = new Label();
            lab3.Margin = new Thickness(0, 50, 0, 0);
            lab3.Width = 200; lab3.Height = 25;
            lab3.Content = "2011";
            paperCanvas.Children.Add(lab3);

            Label lab4 = new Label();
            lab4.Margin = new Thickness(0, 75, 0, 0);
            lab4.Width = 200; lab4.Height = 25;
            lab4.Content = "2012";
            paperCanvas.Children.Add(lab4);

            Label lab5 = new Label();
            lab5.Margin = new Thickness(200, 0, 0, 0);
            lab5.Width = 200; lab4.Height = 25;
            lab5.Content = "150 cm";
            paperCanvas.Children.Add(lab5);

            Label lab6 = new Label();
            lab6.Margin = new Thickness(200, 25, 0, 0);
            lab6.Width = 200; lab6.Height = 25;
            lab6.Content = "175 cm";
            paperCanvas.Children.Add(lab6);

            Label lab7 = new Label();
            lab7.Margin = new Thickness(200, 50, 0, 0);
            lab7.Width = 200; lab7.Height = 25;
            lab7.Content = "120 cm";
            paperCanvas.Children.Add(lab7);

            Label lab8 = new Label();
            lab8.Margin = new Thickness(200, 75, 0, 0);
            lab8.Width = 200; lab8.Height = 25;
            lab8.Content = "130 cm";
            paperCanvas.Children.Add(lab8);
        }
    }
}
