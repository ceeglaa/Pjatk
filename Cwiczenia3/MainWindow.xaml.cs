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

namespace Cwiczenia3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            red.Click += red_Click;
            yellow.Click += yellow_Click;

        }
        private void red_Click(object sender, RoutedEventArgs e)
        {
            var window = new Zadanie2(); window.Show();
        }

        private void yellow_Click(object sender, RoutedEventArgs e)
        {
            var window = new Zadanie3i4(); window.Show();
        }
    }
}
