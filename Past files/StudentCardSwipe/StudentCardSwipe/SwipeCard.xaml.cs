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
using MySql.Data.MySqlClient;
using System.Windows.Threading;
namespace StudentCardSwipe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        /*
        *Database variables using MySQL. Please remove comment if changed to SQL.
        */
        private MySqlConnection connectionVariable;
        private MySqlCommand searchCommand;
        private MySqlCommand insertCommand;
        private MySqlCommand updateCommand;
        private bool studentFound = false;
        private System.Timers.Timer successTimer;
        private string studentInputVariable = "";
        private string refinedStringDate;
        private static readonly DispatcherTimer timer;
        private string userInput;
        private string studentIdSubstring;
        bool justSwiped;
        static MainWindow()
        {

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);

        }// static StudentSwipe()
        public MainWindow()
        {

            InitializeComponent();
            justSwiped = false;
            timer.Tick += timeDelay;
            successTimer = new System.Timers.Timer(3000);
            student_instruction_block.Visibility = Visibility.Visible;
            student_ID_input_box.Focus();

        }

        private void go_back_button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)
        {

            // Student ID is read in here.
            TextBox textInfomationVariable = sender as TextBox;
            studentInputVariable = textInfomationVariable.Text;
            if (studentInputVariable.Length == 18 && !justSwiped)
            {

                /*
                *Database connection using MySQL. Please remove comment if changed to SQL.
                */
                connectionVariable = new MySqlConnection();
                connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
                studentInputVariable = studentInputVariable.Substring(6, 9);
                studentAttendanceTracker(studentInputVariable);
                userInput = studentInputVariable;
                databaseLoginCheck();
                insertTime(studentFound, connectionVariable);
                student_ID_input_box.Clear();
                student_ID_input_box.IsEnabled = false;
                if (studentFound)
                {

                    student_instruction_block.Text = "Successful Swipe!";
                    go_back_button.Visibility = Visibility.Collapsed;
                    timer.Start();

                }// if(loginVariable.StudentFound)
                else
                {

                    student_instruction_block.Text = "Invalid Swipe!";
                    go_back_button.Visibility = Visibility.Collapsed;
                    timer.Start();

                }// else of if(loginVariable.StudentFound)
                justSwiped = true;
            }// if (studentInputVariable.Length == 18)

        }
        // Takes studentId information from string and checks it against known IDs in the database. Comment updated 3/25/2016.
        public void databaseLoginCheck()
        {

            studentIdSubstring = userInput;
            /*
            *Database connection using MySQL. Please remove comment if changed to SQL.
            */
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            connectionVariable.Open();
            searchCommand = new MySqlCommand("SELECT * FROM student WHERE StudentNumber = " + studentIdSubstring, connectionVariable);
            MySqlDataReader reader = searchCommand.ExecuteReader();
            if (reader.HasRows)
            {

                studentFound = true;

            }// if(reader.HasRows
            connectionVariable.Close();

        }// public bool databaseLoginCheck()
        // Method that inserts the time into the date column from the user input. Comment updated 3/29/2016.
        private void insertTime(bool foundInput, MySqlConnection connectionInput)
        {

            /*
            *Database connection using MySQL. Please remove comment if changed to SQL.
            */
            studentFound = false;
            studentIdSubstring = userInput;
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            connectionVariable.Open();
            searchCommand = new MySqlCommand("SELECT * FROM student WHERE StudentNumber = " + studentIdSubstring, connectionVariable);
            MySqlDataReader reader = searchCommand.ExecuteReader();
            if (reader.HasRows)
            {

                studentFound = true;

            }// if(reader.HasRows
            connectionVariable.Close();

    }// private static void insertTime(bool foundInput)
         // Method that creates a moment where the software does not make any changes until amount of
         // time has passed. Comment updated 3/25/2016.
        private void timeDelay(object sender, EventArgs e)
        {

            if (justSwiped)
            {

                justSwiped = false;
                student_instruction_block.Text = "Please swipe ID card:";
                go_back_button.Visibility = Visibility.Visible;
                timer.Stop();

            }// if(justSwiped)
            student_ID_input_box.IsEnabled = true;
            student_ID_input_box.Focus();

        }// private void timeDelay(object sender, EventArgs e)
        // Adds to the attendance counter variable in the database after each successful swipe. Comment update 4/6/2016.
        private void studentAttendanceTracker(string userId)
        {

            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            string findQuery = "UPDATE student SET Attendance = Attendance + 1 WHERE StudentNumber = '" + userId + "';";
            updateCommand = new MySqlCommand(findQuery, connectionVariable);
            connectionVariable.Open();
            updateCommand.ExecuteNonQuery();
            connectionVariable.Close();

        }// private void studentAttendanceTracker(string userID)
    }
}
