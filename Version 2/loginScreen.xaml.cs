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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace StudentAttendanceTracker
{
    
    /// Interaction logic for loginScreen.xaml
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
            string username = this.usernameTextBox.Text;
            string password = this.loginPasswordBox.Password;
            //if username & password are invalid
            
            SqlConnection connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
            SqlDataAdapter searchCommand = new SqlDataAdapter("SELECT Count(*) FROM ProfessorInfo WHERE UserName ='" + username +"' and Password = '" + password + "'", connectionVariable);
            connectionVariable.Open();
            DataTable dt = new DataTable();
            searchCommand.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                homeScreen home = new homeScreen();
                home.Show();
                this.Close();
            }
            //if username & password are valid...
            else
            {
                passwordNotEqual.Content = "The Username and Password combination entered is invalid, please try again!";
            }
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
