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

    /// Interaction logic for registerScreen.xaml

    public partial class registerScreen : Window
    {
        public registerScreen()
        {
            InitializeComponent();
        }

        
        //on register click
        private void registerSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            formFilled.Content = "";
            passwordNotEqual.Content = "";

            //puts everything in textbox's into strings
            String username = usernameTextBox.Text;
            String professorname = professornameTextBox.Text;
            String department = departmentTextBox.Text;
            String email = emailTextBox.Text;
            String password = passwordTextBox.Password;
            String confirmPassword = confirmpasswordTextBox.Password;
            if (passwordCheck(password, confirmPassword) == true)
            {
                SqlConnection connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
                connectionVariable.Open();
                SqlCommand insertCommand = connectionVariable.CreateCommand();
                insertCommand.CommandText = "INSERT into ProfessorInfo ([UserName], [Password], [ProfessorName], [Department], [Email]) values ('" + username + "', '" + password + "','" + professorname + "','" + department + "', '" + email + "')";
                try
                {
                    insertCommand.ExecuteNonQuery();
                    passwordNotEqual.Content = "Record inserted successfully";
                    connectionVariable.Close();
                }
                catch (Exception)
                {
                    passwordNotEqual.Content = "Query execution error";
                }
            }

        }

        private void registerGoBackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newMain = new MainWindow();
            newMain.Show();
            this.Close();
        }

        private bool passwordCheck(string password, string confirmPassword)
        {
            int uppercaseCount = 0;
            int lowercaseCount = 0;
            int numCount = 0;
            int specialCharacterCount = 0;
            bool valid = false;
            if (password.Length < 6)
            {
                registerConfirmPassword_Copy.Content = ("Your password must be at least 10 characters.");
                valid = false;
            }
            else
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsUpper(password[i]) == true)
                    {
                        uppercaseCount = 1;
                    }
                    if (Char.IsLower(password[i]) == true)
                    {
                        lowercaseCount = 1;
                    }
                    if (Char.IsDigit(password[i]) == true)
                    {
                        numCount = 1;
                    }
                    if (Char.IsPunctuation(password[i]) == true)
                    {
                        specialCharacterCount = 1;
                    }
                }

                if (uppercaseCount != 1)
                {
                    registerConfirmPassword_Copy.Content = ("Your password needs to have an uppercase letter.");
                    valid = false;
                }
                else if (lowercaseCount != 1)
                {
                    registerConfirmPassword_Copy.Content = ("Your password needs to have a lowercase letter.");
                    valid = false;
                }
                else if (numCount != 1)
                {
                    registerConfirmPassword_Copy.Content = ("Your password must have a number.");
                    valid = false;
                }
                else if (specialCharacterCount != 1)
                {
                    registerConfirmPassword_Copy.Content = ("Your password must have a punctuation mark.");
                    valid = false;
                }
                else if (password != confirmPassword)
                {
                    registerConfirmPassword_Copy.Content = ("The passwords do not match!");
                }
                else
                {
                    registerConfirmPassword_Copy.Content = ("Valid password!");
                    valid = true;
                }
            }
            return valid;
        }

        
    }
}
