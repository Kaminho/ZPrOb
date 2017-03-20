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

namespace zad3.Views
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void AddStudentView_Click(object sender, RoutedEventArgs e)
        {
            Content = new AddStudentMenu();
        }

        private void AddCourseView_Click(object sender, RoutedEventArgs e)
        {
            Content = new AddCourseMenu();
        }

        private void AddPresenceView_Click(object sender, RoutedEventArgs e)
        {
            Content = new AddPresenceMenu();
        }

        private void AddMarkView_Click(object sender, RoutedEventArgs e)
        {
            Content = new AddMarkMenu();
        }

        private void ShowStudentsView_Click(object sender, RoutedEventArgs e)
        {
            Content = new ShowStudentsView();
        }

        private void ShowCoursesView_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowPresencesView_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowMarksView_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
