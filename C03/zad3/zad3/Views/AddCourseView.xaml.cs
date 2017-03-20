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
    /// Interaction logic for AddCourseMenu.xaml
    /// </summary>
    public partial class AddCourseMenu : Page
    {
        public AddCourseMenu()
        {
            InitializeComponent();
            InitForm();
        }



        private void btn_Click(object sender, RoutedEventArgs e)
        {
            using (DbEntities db = new DbEntities())
            {
                Course course = new Course() { Name = tbName.Text, Date = (DateTime)dpDate.SelectedDate };
                db.Course.Add(course);

                if (db.SaveChanges() == 1)
                    MessageBox.Show("Dodano przedmiot", "Dodano przedmiot", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void InitForm()
        {       
            using (DbEntities db = new DbEntities())
            { 
                List<Student> students = db.Student.ToList();
                List<Course> courses = db.Course.ToList();

                AddPresenceMenuBinding addCourseBinding = new AddPresenceMenuBinding(students, courses);
                gAddCourse.DataContext = addCourseBinding;
            }
        }
    }
}
