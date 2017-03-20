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
    /// Interaction logic for AddPresenceMenu.xaml
    /// </summary>
    public partial class AddPresenceMenu : Page
    {
        public AddPresenceMenu()
        {
            InitializeComponent();
            InitForm();
        }



        private void btn_Click(object sender, RoutedEventArgs e)
        {
            using (DbEntities db = new DbEntities())
            {
                bool p = cbValue.SelectedItem == "Tak" ? true : false;
                Presence presence = new Presence() { IdStudent = ((Student)cbStudent.SelectedItem).Id, IdCourse = ((Course)cbCourse.SelectedItem).Id, Value = p};
                db.Presence.Add(presence);

                if (db.SaveChanges() == 1)
                    MessageBox.Show("Dodano obecność", "Dodano obecność", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }

        private void InitForm()
        {
            AddPresenceMenuBinding addCourseBinding;
            using (DbEntities db = new DbEntities())
            {
                List<Student> students = db.Student.ToList();
                List<Course> courses = db.Course.ToList();

                addCourseBinding = new AddPresenceMenuBinding(students, courses);
                gAddPersence.DataContext = addCourseBinding;
            }
                            cbCourse.SelectedIndex = 0;
                cbStudent.SelectedIndex = 0;
                cbValue.SelectedIndex = 0;
        }
    }
}
