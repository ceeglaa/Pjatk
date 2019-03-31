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
    /// Interaction logic for Zadanie3i4.xaml
    /// </summary>
    public partial class Zadanie3i4 : Window
    {
        public List<Student> studenci = new List<Student>();
        public Zadanie3i4()
        {
            InitializeComponent();
            Add.Click += Add_click;
            Delete.Click += Delete_click;

            studenci.Add(new Student { FirstName = "Jan", LastName = "Kowalski", IndexNumber = "s1234" });
            studenci.Add(new Student { FirstName = "Mariusz", LastName = "Kowalski", IndexNumber = "s1234" });
            studenci.Add(new Student { FirstName = "Andrzej", LastName = "Kowalski", IndexNumber = "s1234" });

            StudentsDataGrid.ItemsSource = studenci;
           
        }
        private void Add_click(object sender, RoutedEventArgs e)
        {
            studenci.Add(new Student { FirstName = Name.Text , LastName = Last_Name.Text, IndexNumber = Index_Number.Text });
            StudentsDataGrid.Items.Refresh();

        }

        private void Delete_click(object sender, RoutedEventArgs e)
        {
            Student student = (Student)StudentsDataGrid.SelectedItem;
            studenci.Remove(student);
            StudentsDataGrid.Items.Refresh();

        }

        private void EditStudent(object sender, RoutedEventArgs e) {
            Student student = (Student)StudentsDataGrid.SelectedItem;
            var window = new StudentEditDialog(student); window.Show();
        }

    }
}
