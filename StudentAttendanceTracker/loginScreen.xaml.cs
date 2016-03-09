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
    /// Interaction logic for loginScreen.xaml
    /// </summary>
    public partial class loginScreen : Window
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //check the credentials entered in the text boxes, advance to home screen if valid. else tell user credentials are invalid
        private void loginSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            * Check the validity of the credentials against the database here!!!
            */
            homeScreen home = new homeScreen();
            home.Show();
            this.Close();
        }

        //close this login window and open up the welcome window
        private void loginGoBackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow welcome = new MainWindow();
            welcome.Show();
            this.Close();
        }
    }
}
