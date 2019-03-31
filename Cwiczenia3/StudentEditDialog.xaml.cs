using System;
using Cwiczenia3.Models;
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
using System.Windows.Shapes;

namespace Cwiczenia3
{
    /// <summary>
    /// Interaction logic for StudentEditDialog.xaml
    /// </summary>
    public partial class StudentEditDialog : Window
    {
        public StudentEditDialog(Student student)
        {
            InitializeComponent();
            Name.Text = student.FirstName;
            Last_Name.Text = student.LastName;
            Index_Number.Text = student.IndexNumber;
            Close_Button.Click += Close_Button_Click;
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
