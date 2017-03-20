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
using zad3.Models;

namespace zad3.Views
{
    /// <summary>
    /// Interaction logic for AddStudentMenu.xaml
    /// </summary>
    public partial class AddStudentMenu : Page
    {
        public AddStudentMenu()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            using (DbEntities db = new DbEntities())
            {
                Student student = new Student() { Name = tbName.Text, Surname = tbSurname.Text };
                db.Student.Add(student);

                if (db.SaveChanges() == 1)
                    MessageBox.Show("Dodano ucznia", "Dodano ucznia", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}
