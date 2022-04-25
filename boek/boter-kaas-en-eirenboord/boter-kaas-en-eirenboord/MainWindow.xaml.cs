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

namespace boter_kaas_en_eirenboord
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
            rect.Width = 100; rect.Height = 100;
            rect.Margin = new Thickness(0, 0, 0, 0);
            rect.Stroke = new SolidColorBrush(Colors.Black);
            peaperCanvas.Children.Add(rect);

            Rectangle rect2 = new Rectangle();
            rect2.Width = 100; rect2.Height = 100;
            rect2.Margin = new Thickness(100, 0, 0, 0);
            rect2.Stroke = new SolidColorBrush(Colors.Black);
            peaperCanvas.Children.Add(rect2);

            Rectangle rect3 = new Rectangle();
            rect3.Width = 100; rect3.Height = 100;
            rect3.Margin = new Thickness(200, 0, 0, 0);
            rect3.Stroke = new SolidColorBrush(Colors.Black);
            peaperCanvas.Children.Add(rect3);

            Rectangle rect4 = new Rectangle();
            rect4.Width = 100; rect4.Height = 100;
            rect4.Margin = new Thickness(0, 100, 0, 0);
            rect4.Stroke = new SolidColorBrush(Colors.Black);
            peaperCanvas.Children.Add(rect4);

            Rectangle rect5 = new Rectangle();
            rect5.Width = 100; rect5.Height = 100;
            rect5.Margin = new Thickness(100, 100, 0, 0);
            rect5.Stroke = new SolidColorBrush(Colors.Black);
            peaperCanvas.Children.Add(rect5);

            Rectangle rect6 = new Rectangle();
            rect6.Width = 100; rect6.Height = 100;
            rect6.Margin = new Thickness(200, 100, 0, 0);
            rect6.Stroke = new SolidColorBrush(Colors.Black);
            peaperCanvas.Children.Add(rect6);

            Rectangle rect7 = new Rectangle();
            rect7.Width = 100; rect7.Height = 100;
            rect7.Margin = new Thickness(0, 200, 0, 0);
            rect7.Stroke = new SolidColorBrush(Colors.Black);
            peaperCanvas.Children.Add(rect7);

            Rectangle rect8 = new Rectangle();
            rect8.Width = 100; rect8.Height = 100;
            rect8.Margin = new Thickness(100, 200, 0, 0);
            rect8.Stroke = new SolidColorBrush(Colors.Black);
            peaperCanvas.Children.Add(rect8);

            Rectangle rect9 = new Rectangle();
            rect9.Width = 100; rect9.Height = 100;
            rect9.Margin = new Thickness(200, 200, 0, 0);
            rect9.Stroke = new SolidColorBrush(Colors.Black);
            peaperCanvas.Children.Add(rect9);

        }
    }
}
