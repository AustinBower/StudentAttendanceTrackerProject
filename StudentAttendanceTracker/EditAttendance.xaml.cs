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
/*Creates A UI that asks for the name and checks to see that person is in the database. Comment upated 3/31/2016.*/
namespace StudentAttendanceTracker
{
    /// <summary>
    /// Interaction logic for EditAttendance.xaml
    /// </summary>
    public partial class EditAttendance : Window
    {
        
        DialogBox dialog;
        public EditAttendance()
        {

            InitializeComponent();
            dialog = new DialogBox();

        }// public EditAttendance()
        // Opens the DialogBox UI if the user is found. Comment updated 3/31/2016.
        private void Enter_Student_Name_Button_Click(object sender, RoutedEventArgs e)
        {

            dialog.UserInput = Student_Name_Combobox.Text;
            dialog.studentSwipesLogged();
            if(dialog.PersonFound)
            {

                dialog.ShowDialog();

            }// if(dialog.PersonFound)
        }// private void Enter_Student_Name_Button_Click(object sender, RoutedEventArgs e)
        // Closes the Edit_Attendance Window. Comment updated 3/31/2016.
        private void Return_To_Home_Screen_Button_Click(object sender, RoutedEventArgs e)
        {

            homeScreen home = new homeScreen();
            home.Show();
            this.Close();

        }// private void Return_To_Home_Screen_Button_Click(object sender, RoutedEventArgs e)
        // Closes the Dialogbox that is opened to allow blog file manipulation. Comment Updated 3/31/2016. 
        private void EditAttendence_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            dialog.UserInput = "";
            dialog.Close();

        }// private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        // Combobox that gives the professor the list of students in th class. Comment updated 4/6/2016.
        private void Student_Name_Combobox_Initialized(object sender, EventArgs e)
        {

            MySqlConnection connectionVariable;
            MySqlCommand searchCommand;
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            string findQuery = "SELECT StudentName FROM student;";
            searchCommand = new MySqlCommand(findQuery, connectionVariable);
            connectionVariable.Open();
            MySqlDataReader reader;
            reader = searchCommand.ExecuteReader();
            while (reader.Read())
            {

                Student_Name_Combobox.Items.Add(reader["StudentName"]);

            }// while(reader.Read())
            reader.Close();
            connectionVariable.Close();

        }// private void Student_Name_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)

    }// public partial class EditAttendance : Window

}// namespace Example
