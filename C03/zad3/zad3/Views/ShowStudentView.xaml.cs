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
    /// Interaction logic for ShowStudentView.xaml
    /// </summary>
    public partial class ShowStudentView : Page
    {
        private Student student;

        public ShowStudentView()
        {
            InitializeComponent();
            InitForm();
        }

        public ShowStudentView(Student student)
        {       
            this.student = student;
            InitializeComponent();
            InitForm();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Content = new ShowStudentsView();
        }

        private void InitForm()
        {
            gShowStudent.DataContext = student;
        }
    }
}
