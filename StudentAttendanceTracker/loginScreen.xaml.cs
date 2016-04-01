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
using MySql.Data.MySqlClient;

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
            string username = this.usernameTextBox.Text;
            string password = this.loginPasswordBox.Password;
            //if username & password are invalid
            MySqlConnection connectionVariable;
            MySqlCommand searchCommand;
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=localhost;uid=root;pwd=;database=professor;";
            searchCommand = new MySqlCommand("SELECT * FROM professorinformation WHERE username ='" + username +"'", connectionVariable);
            connectionVariable.Open();
            MySqlDataReader reader = searchCommand.ExecuteReader();
            if(reader.HasRows)
            {
                homeScreen home = new homeScreen();
                home.Show();
                this.Close();
                connectionVariable.Close();
            }
            //if username & password are valid...
            else
            {
                MessageBox.Show("INVALID CRENDENTIALS! The username / password combination entered is invalid, please try again.", "Invalid Credentials");
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
