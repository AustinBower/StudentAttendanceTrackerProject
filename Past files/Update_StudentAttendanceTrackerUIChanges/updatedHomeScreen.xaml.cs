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
using System.Windows.Shapes;

namespace StudentAttendanceTracker
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class updatedHomeScreen : Window
    {
        public updatedHomeScreen()
        {
            InitializeComponent();
        }

        private void addCourseButton_Click(object sender, RoutedEventArgs e)
        {
            addCourse addCourseWindow = new addCourse();
            addCourseWindow.Show();
            this.Close();
        }

        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            addStudent addStudentWindow = new addStudent();
            addStudentWindow.Show();
            this.Close();
        }

        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            * Add a check to make sure that the user wants to exit
            */
            MainWindow welcome = new MainWindow();
            welcome.Show();
            this.Close();
        }

        private void addCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            addCourse addCourseWindow = new addCourse();
            addCourseWindow.Show();
            this.Close();
        }
    }
}
