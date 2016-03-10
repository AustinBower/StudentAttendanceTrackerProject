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
    /// Interaction logic for homeScreen.xaml
    /// </summary>
    public partial class homeScreen : Window
    {
        public homeScreen()
        {
            InitializeComponent();
        }


        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            addStudent addStudentWindow = new addStudent();
            addStudentWindow.Show();
            this.Close();
        }

        //close the home window and go back to the welcome window
        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            * Add a check to make sure that the user wants to exit
            */
            MainWindow welcome = new MainWindow();
            welcome.Show();
            this.Close();
        }
    }
}
