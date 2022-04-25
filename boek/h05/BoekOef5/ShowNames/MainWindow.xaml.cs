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

namespace ShowNames
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

        public void ShowNames(string name, string surname)
        {
            MessageBox.Show(name);
            MessageBox.Show(surname);
        }
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ShowNames(txtName.Text, txtSurname.Text);

        }
    }
}
