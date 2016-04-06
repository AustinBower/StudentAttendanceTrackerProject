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
    /// Interaction logic for registerScreen.xaml
    /// </summary>
    public partial class registerScreen : Window
    {
        public registerScreen()
        {
            InitializeComponent();
        }

        

        private void registerSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            formFilled.Content = "";
            passwordNotEqual.Content = "";

            //puts everything in textbox's into strings
            String username = usernameTextBox.Text;
            String firstname = firstnameTextBox.Text;
            String lastname = lastnameTextBox.Text;
            String email = emailTextBox.Text;
            String password = passwordTextBox.Text;
            String confirmPassword = confirmpasswordTextBox.Text;

            //checks to see if all of the fields at least have something, and checks to see if passwords are equal
           

            if (password == confirmPassword && username.Length > 0 && firstname.Length > 0 && lastname.Length > 0 && email.Length > 0 && password.Length > 0)
            {

            }

            else if (username.Length == 0 || firstname.Length == 0 || lastname.Length == 0 || email.Length == 0 || password.Length == 0)
            {
                formFilled.Content = "Please complete every field.";
            }

            else if (password != confirmPassword)
            {
                passwordNotEqual.Content = "Your passwords do not match!";
            }

        }

        private void registerGoBackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newMain = new MainWindow();
            newMain.Show();
            this.Close();
        }

        
    }
}
