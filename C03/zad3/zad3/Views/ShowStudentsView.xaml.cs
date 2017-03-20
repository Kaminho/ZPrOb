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
using System.Data.Entity;

namespace zad3.Views
{
    /// <summary>
    /// Interaction logic for ShowStudentMenu.xaml
    /// </summary>
    public partial class ShowStudentsView : Page
    {
        public ShowStudentsView()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            using (DbEntities db = new DbEntities())
                lvShowStudents.ItemsSource = db.Student.ToList();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lvShowStudents.SelectedItem == null)
                MessageBox.Show("Zaznacz osobę do usunięcia", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (MessageBox.Show("Czy napewno usunąć?", "Usuń", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    using (DbEntities db = new DbEntities())
                    {
                        Student student = (Student)lvShowStudents.SelectedItem;
                        db.Entry(student).State = EntityState.Deleted;
                        db.SaveChanges();

                        lvShowStudents.ItemsSource = db.Student.ToList();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (lvShowStudents.SelectedItem == null)
                MessageBox.Show("Zaznacz osobę do edycji", "Uwaga", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
                Content = new ShowStudentView((Student)lvShowStudents.SelectedItem);
    
        }
    }
}
