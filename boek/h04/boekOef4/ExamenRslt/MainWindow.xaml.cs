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

namespace ExamenRslt
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int outComeStudent1 = 44;
            int outComeStudent2 = 51;
            double outComeStudentDouble1 = outComeStudent1;
            double outComeStudentDouble2 = outComeStudent2;
            double resultDouble = (outComeStudentDouble1 + outComeStudentDouble2) / 2;


         //   int result = (outComeStudent1 + outComeStudent2) / 2;

            lblReslult.Content = $"De gemiddelde score van de examen: {resultDouble}";


        }
    }
}
