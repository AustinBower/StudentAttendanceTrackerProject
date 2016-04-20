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

        private void registerGoBackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newMain = new MainWindow();
            newMain.Show();
            this.Close();
        }

        
    }
}
