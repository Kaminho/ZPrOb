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
    /// Interaction logic for AddMarkMenu.xaml
    /// </summary>
    public partial class AddMarkMenu : Page
    {
        public AddMarkMenu()
        {
            InitializeComponent();
            InitForm();
        }



        private void btn_Click(object sender, RoutedEventArgs e)
        {
            using (DbEntities db = new DbEntities())
            {
                Mark mark = new Mark() { IdStudent = ((Student)cbStudent.SelectedItem).Id, IdCourse = ((Course)cbCourse.SelectedItem).Id, Value = (double)cbValue.SelectedItem };
                db.Mark.Add(mark);

                if (db.SaveChanges() == 1)
                    MessageBox.Show("Dodano Ocenę", "Dodano Ocenę", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void InitForm()
        {
            using (DbEntities db = new DbEntities())
            {
                List<Student> students = db.Student.ToList();
                List<Course> courses = db.Course.ToList();

                AddMarkMenuBinding binding = new AddMarkMenuBinding(students, courses);
                gAddMark.DataContext = binding;
            }

            cbCourse.SelectedIndex = 0;
            cbStudent.SelectedIndex = 0;
            cbValue.SelectedIndex = 0;
        }
    }
}
