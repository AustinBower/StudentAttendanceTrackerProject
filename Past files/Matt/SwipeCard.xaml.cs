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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Threading;
namespace StudentAttendanceTracker
{
    /// <summary>
    /// Interaction logic for SwipeCard.xaml
    /// </summary>
    public partial class SwipeCard : Window
    {

        /*
        *Database variables using SQL Server. 
        */
        private SqlConnection connectionVariable;
        private SqlCommand searchCommand;
        private SqlCommand insertCommand;
        private SqlCommand updateCommand;
        private bool studentFound = false;
        private System.Timers.Timer successTimer;
        private string studentInputVariable = "";
        private string dateSubstring;
        private static readonly DispatcherTimer timer;
        private string userInput;
        private string studentIdSubstring;
        private string classNameInput;
        private string courseNumberString;
        bool justSwiped;
        static SwipeCard()
        {

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);

        }// static StudentSwipe()
        /// <summary>
        /// Method that intializes the events for the StudentSwipe UI. Comment updated 4/20/2016.
        /// </summary>
        public SwipeCard()
        {

            InitializeComponent();
            justSwiped = false;
            timer.Tick += timeDelay;
            successTimer = new System.Timers.Timer(3000);
            student_instruction_block.Visibility = Visibility.Visible;
            student_ID_input_box.Focus();

        }
        /// <summary>
        /// Button event used to return to the menu screen. Comment updated 4/20/2016.
        /// </summary>
        /// <param name="sender"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        /// <param name="e"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        private void go_back_button_Click(object sender, RoutedEventArgs e)
        {

            homeScreen homeScreenWindow = new homeScreen();
            homeScreenWindow.Show();
            this.Close();

        }
        /// <summary>
        /// Event for textbox used to input ID swipe. Comment updated 4/20/2016.
        /// </summary>
        /// <param name="sender"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        /// <param name="e"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)
        {

            TextBox textInfomationVariable = sender as TextBox;
            studentInputVariable = textInfomationVariable.Text;
            if (studentInputVariable.Length == 18 && !justSwiped)
            {
                studentInputVariable = studentInputVariable.Substring(6, 9);
                //retrieveCourseNumber(class_select_comboBox.Text);
                courseNumberString = classNameInput;
                studentAttendanceTracker(studentInputVariable);
                studentInputVariable = studentInputVariable + " " + GetDate(DateTime.Today);
                studentInputVariable = studentInputVariable + " " + DateTime.Now.ToString("HH:mm:ss");
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
            }

        }
        /// <summary>
        /// Returns date the user swiped in. Comment updated 3/25/2016.
        /// </summary>
        /// <param name="Date"> Brings in the information from the class DateTime. Comment updated 4/202/2016. </param>
        /// <returns> Returns the date the user swiped in. Comment updated 4/20/2016. </returns>
        public string GetDate(DateTime Date)
        {            

            string tempStringVariable = "";
            string[] DateStringVariable = Date.GetDateTimeFormats(); 
            tempStringVariable = DateStringVariable[6];
            tempStringVariable=tempStringVariable.Replace("/", "-");
            return tempStringVariable;

        }
        /// <summary>
        /// Takes studentId information from string and checks it against known IDs in the database. Comment updated 3/25/2016.
        /// </summary>
        public void databaseLoginCheck()
        {

            studentFound = false;
            studentIdSubstring = userInput.Substring(0, 9);         
            connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
            connectionVariable.Open();
            searchCommand = new SqlCommand("SELECT * FROM StudentInfo WHERE StudentNumber = " + studentIdSubstring, connectionVariable);
            SqlDataReader reader = searchCommand.ExecuteReader();
            if (reader.HasRows)
            {

                studentFound = true;

            }// if(reader.HasRows
            connectionVariable.Close();

        }
        /// <summary>
        /// Method that inserts the time into the date column from the user input. Comment updated 3/29/2016. 
        /// </summary>
        private void insertTime(bool foundInput, SqlConnection connectionInput)
        {
            connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
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
                connectionInput.Open();
                SqlDataReader reader;
                string query = "INSERT INTO AttendanceDetails([AttendanceDate],[AttendanceTime],[StudentID]) SELECT '" + dateRefinedString + "' , '" + dateSubstring.Substring(counter) + "', StudentID from StudentInfo where StudentNumber = '" + userInput.Substring(0, 9) + "';";
                insertCommand = new SqlCommand(query, connectionInput);
                reader = insertCommand.ExecuteReader();
            }// if(foundInput) 
            connectionInput.Close();

        }
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

        }
        /// <summary>
        /// Adds 1 to the attendance after each swipe to show how many swipes have been made by the student.
        /// Comment updated 4/16/2016.
        /// </summary>
        /// <param name="userId"> UserId brings in the student ID number to be used in the database
        /// for selecting the student who swiped in. Comment updated 4/20/2016. </param>
        private void studentAttendanceTracker(string userId)
        {

            connectionVariable = new SqlConnection();
            connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
            string findQuery = "update StudentInfo set Attendances=Attendances+1 from StudentInfo join CourseInfo on CourseInfo.CourseID = StudentInfo.CourseID where StudentNumber='"+ userId +"' and CRN = '"+class_select_comboBox.Text+"'";
            updateCommand = new SqlCommand(findQuery, connectionVariable);
            connectionVariable.Open();
            updateCommand.ExecuteNonQuery();
            connectionVariable.Close();

        }

        /*public void retrieveCourseNumber(string userInput)
        {
            
            SqlConnection connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
            connectionVariable.Open();
            SqlCommand searchCommand = new SqlCommand("SELECT CRN FROM CourseInfo WHERE CRN = '" + userInput + "'", connectionVariable);
            SqlDataReader reader = searchCommand.ExecuteReader();
            reader.Read();
            classNameInput = reader.GetString("CRN");
            reader.Close();
            connectionVariable.Close();
            
         }*/
        /// <summary>
        /// Combobox event that allows the professors to select which class the student swipes for. Comment updated 4/20/2016.
        /// </summary>
        /// <param name="sender"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        /// <param name="e"> Default parameter for the UI event. Comment updated 4/20/2016. </param>
        private void class_select_comboBox_Initialized(object sender, EventArgs e)
        {

            SqlConnection connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
            connectionVariable.Open();
            SqlCommand courseCommand = new SqlCommand("SELECT CRN FROM CourseInfo", connectionVariable);
            SqlDataReader reader = courseCommand.ExecuteReader();
            Console.WriteLine(reader);
            while (reader.Read())
            {
                class_select_comboBox.Items.Add(reader["CRN"]);

            }// while(reader.Read())
            reader.Close();
            connectionVariable.Close();
            student_ID_input_box.Focus();

        }

    }

}
