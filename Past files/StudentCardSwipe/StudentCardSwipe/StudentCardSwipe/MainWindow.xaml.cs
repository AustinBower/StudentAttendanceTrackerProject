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
        private string dateSubstring;
        private static readonly DispatcherTimer timer;
        private string userInput;
        private string studentIdSubstring;
        private string classNameInput;
        private string courseNumberString;
        bool justSwiped;
        static MainWindow()
        {

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);

        }// static StudentSwipe()
        /// <summary>
        /// Method that intializes the events for the StudentSwipe UI. Comment updated 4/20/2016.
        /// </summary>
        public MainWindow()
        {

            InitializeComponent();
            justSwiped = false;
            timer.Tick += timeDelay;
            successTimer = new System.Timers.Timer(3000);
            student_instruction_block.Visibility = Visibility.Visible;
            student_ID_input_box.Focus();

        }// public MainWindow()
        /// <summary>
        /// Button event used to return to the menu screen. Comment updated 4/20/2016.
        /// </summary>
        /// <param name="sender"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        /// <param name="e"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        private void go_back_button_Click(object sender, RoutedEventArgs e)
        {


        }// private void go_back_button_Click(object sender, RoutedEventArgs e)
        /// <summary>
        /// Event for textbox used to input ID swipe. Comment updated 4/20/2016.
        /// </summary>
        /// <param name="sender"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        /// <param name="e"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
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
                studentInputVariable = studentInputVariable + " " + GetDate(DateTime.Today);
                studentInputVariable = studentInputVariable + " " + DateTime.Now.ToString("HH:mm:ss");
                userInput = studentInputVariable;
                databaseLoginCheck();
                insertTime(studentFound);
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

        }// private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)
        /// <summary>
        /// Returns the time the user swiped in using 24-hour clock time. Comment updated 3/25/2016.
        /// </summary>
        /// <param name="Date"> Brings in the information from the class DateTime. Comment updated 4/202/2016. </param>
        /// <returns> Returns the time the user swiped in. Comment updated 4/20/2016. </returns>
        public string GetDate(DateTime Date)
        {

            int counter = 0;
            string tempStringVariable = "";
            Date = DateTime.Today;
            try
            {

                // Removes the added time information at the end of the Date variable. Comment updated 3/25/2016.
                while (Date.ToString().Substring(counter, 1) != " ")
                {

                    refinedStringDate = tempStringVariable + Date.ToString().Substring(counter, 1);
                    tempStringVariable = refinedStringDate;
                    counter++;

                }// while (Date.ToString().Substring(counter, 1) != " ")

            }// try 1
            catch
            {

                Console.WriteLine("Error date counter exceeded string length!");
                refinedStringDate = "";

            }// catch 1

            return refinedStringDate;

        }// public string GetDate(DateTime Date)
        /// <summary>
        /// Takes studentId information from string and checks it against known IDs in the database. Comment updated 3/25/2016.
        /// </summary>
        public void databaseLoginCheck()
        {

            studentFound = false;
            studentIdSubstring = userInput.Substring(0, 9);
            /*
            *Database connection using MySQL. Please remove comment if changed to SQL.
            */
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            connectionVariable.Open();
            searchCommand = new MySqlCommand("SELECT * FROM student WHERE StudentNumber = '" + studentIdSubstring + "' AND ClassID = '" + courseNumberString + "'", connectionVariable);
            MySqlDataReader reader = searchCommand.ExecuteReader();
            if (reader.HasRows)
            {

                studentFound = true;

            }// if(reader.HasRows
            connectionVariable.Close();

        }// public bool databaseLoginCheck()
        /// <summary>
        /// Method that inserts the time into the date column from the user input. Comment updated 3/29/2016. 
        /// </summary>
        /// <param name="foundInput"> Used to bring the boolean that determine if
        /// the database is accessed. Comment updated 4/20/2016. </param>
        private void insertTime(bool foundInput)
        {

            /*
            *Database connection using MySQL. Please remove comment if changed to SQL.
            */
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            if (foundInput)
            {

                int counter = 0;
                string tempStringVariable = "";
                dateSubstring = userInput.Substring(10);
                string dateRefinedString = "";
                while (dateSubstring.Substring(counter, 1) != " ")
                {

                    dateRefinedString = tempStringVariable + dateSubstring.Substring(counter, 1);
                    tempStringVariable = dateRefinedString;
                    counter++;

                }// while (Date.ToString().Substring(counter, 1) != " ")
                string findQuery = "SELECT AttendanceDate FROM StudentInfo WHERE StudentNumber = '" + userInput.Substring(0, 9) + "' AND ClassID = '" + courseNumberString + "';";
                searchCommand = new MySqlCommand(findQuery, connectionVariable);
                connectionVariable.Open();
                MySqlDataReader reader;
                reader = searchCommand.ExecuteReader();
                reader.Read();
                reader.Close();
                /*
                
                   string query = "UPDATE swipecard.student SET Date ='" + currentDateString + "' WHERE StudentNumber = '" + userInput.Substring(0, 9) + "' AND ClassID = '" + courseNumberString + "';";
                   
                   This line of code is used to update the database using the course number of the class the student is in to refine between multiple entries of the same student.
                   The AND ClassID part is really what matters.
                   If converted to SQL please remove.
                    
                */
                string query = "UPDATE StudentAttendanceTracker.AttendanceDetails SET AttendanceDate ='" + dateRefinedString + "' AND SET AttendanceTime = '" + dateSubstring.Substring(counter) + "' WHERE StudentNumber = " + userInput.Substring(0, 9) + ";";
                insertCommand = new MySqlCommand(query, connectionVariable);
                reader = insertCommand.ExecuteReader();
                while (reader.Read())
                {

                }// while(reader.Read())

            }// if(foundInput) 
            connectionVariable.Close();

        }// private static void insertTime(bool foundInput)
         /// <summary>
         /// Method that creates a moment where the software does not make any changes until amount of
         /// time has passed. Comment updated 3/25/2016.
         /// </summary>
         /// <param name="sender"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
         /// <param name="e"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
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
        /// <summary>
        /// Adds 1 to the attendance after each swipe to show how many swipes have been made by the student.
        /// Comment updated 4/16/2016.
        /// </summary>
        /// <param name="userId"> UserId brings in the student ID number to be used in the database
        /// for selecting the student who swiped in. Comment updated 4/20/2016. </param>
        private void studentAttendanceTracker(string userId)
        {

            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            string findQuery = "UPDATE student SET Attendance = Attendance + 1 WHERE StudentNumber = '" + userId + "' AND ClassId ='" + courseNumberString + "';";
            updateCommand = new MySqlCommand(findQuery, connectionVariable);
            connectionVariable.Open();
            updateCommand.ExecuteNonQuery();
            connectionVariable.Close();

        }// private void studentAttendanceTracker(string userID)
        /// <summary>
        /// uses the chosen class name to get the course number of class. Comment updated 4/17/2016.
        /// </summary>
        /// <param name="userInput"> Brings in the name of the class from the combobox event to be used 
        /// in determining which class is selected. Comment updated 4/20/2016. </param>
        public void retrieveCourseNumber(string userInput)
        {

            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            connectionVariable.Open();
            searchCommand = new MySqlCommand("SELECT CourseNumber FROM courses WHERE Class = '" + userInput + "'", connectionVariable);
            MySqlDataReader reader = searchCommand.ExecuteReader();
            reader.Read();
            classNameInput = reader.GetString("CourseNumber");
            reader.Close();
            connectionVariable.Close();

        }// public void retrieveCourseNumber(string classNameInput)
        /// <summary>
        /// Combobox event that allows the professors to select which class the student swipes for. Comment updated 4/20/2016.
        /// </summary>
        /// <param name="sender"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        /// <param name="e"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        private void class_select_comboBox_Initialized(object sender, EventArgs e)
        {

            Console.WriteLine("entered the combobox");
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            string findQuery = "SELECT Class FROM courses;";
            searchCommand = new MySqlCommand(findQuery, connectionVariable);
            connectionVariable.Open();
            MySqlDataReader reader;
            reader = searchCommand.ExecuteReader();
            Console.WriteLine(reader);
            while (reader.Read())
            {

                class_select_comboBox.Items.Add(reader["Class"]);

            }// while(reader.Read())
            reader.Close();
            connectionVariable.Close();
            student_ID_input_box.Focus();

        }// private void class_select_comboBox_Initialized(object sender, EventArgs e)

    }
}
