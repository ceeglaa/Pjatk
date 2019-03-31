using System;
using System.Collections.Generic;
using Cwiczenia3.Models;
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
using System.Windows.Shapes;

namespace Cwiczenia3
{
    /// <summary>
    /// Interaction logic for Zadanie2.xaml
    /// </summary>
    public partial class Zadanie2 : Window
    {
        public Zadanie2()
        {
            InitializeComponent();
            Close_Button.Click += Close_Button_Click;

        }

        private void ComboBoxStatus_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            ComboBoxItem item = Status.SelectedItem as ComboBoxItem;
            Selected_Status.Text = item.Content.ToString();
        }
        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
