using System.Data.SqlClient;
using System.Data;
using System;
using MySql.Data.MySqlClient;
/*This class accesses the database and checks to see if the information swiped in is a current student
in the class. If the swipe is valid, the date and time are inputted into the database.
Comment updated 3/25/2016.*/
namespace StudentAttendanceTracker
{

    public class StudentLogin
    {

        private MySqlConnection connectionVariable;
        private MySqlCommand searchCommand;
        private MySqlCommand insertCommand;
        private bool studentFound = false;
        private string userInput;
        private string studentIdSubstring;
        private string dateSubstring;
        // Takes studentId information from string and checks it against known IDs in the database. Comment updated 3/25/2016.
        public void databaseLoginCheck()
        {

            studentIdSubstring = userInput.Substring(0, 9);
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            connectionVariable.Open();
            searchCommand = new MySqlCommand("SELECT * FROM student WHERE StudentNumber = " + studentIdSubstring, connectionVariable);
            MySqlDataReader reader = searchCommand.ExecuteReader();
            if(reader.HasRows)
            {

                connectionVariable.Close();
                studentFound = true;

            }// if(reader.HasRows)
            insertTime(studentFound, connectionVariable);
            connectionVariable.Close();

        }// public bool databaseLoginCheck()
        // Method that inserts the time into the date column from the user input. Comment updated 3/29/2016.
        private void insertTime(bool foundInput, MySqlConnection connectionInput)
        {

            if(foundInput)
            {
                dateSubstring = userInput.Substring(10);
                string findQuery = "SELECT Date FROM student WHERE StudentNumber =" + userInput.Substring(0, 9) + ";";
                searchCommand = new MySqlCommand(findQuery, connectionInput);
                connectionInput.Open();
                MySqlDataReader reader;
                reader = searchCommand.ExecuteReader();
                reader.Read();
                string currentDateString = reader.GetString("Date");
                currentDateString += "\n" + dateSubstring;
                reader.Close();

                string query = "UPDATE swipecard.student SET Date ='" + currentDateString + "' WHERE StudentNumber = " + userInput.Substring(0, 9) + ";";
                insertCommand = new MySqlCommand(query, connectionInput);
                reader = insertCommand.ExecuteReader();
                while(reader.Read())
                {

                }// while(reader.Read())

            }// if(foundInput) 

        }// private static void insertTime(bool foundInput)
        // Method fills the dateSubstring and timeSubstring. Comment updated 3/29/2016.
        public bool StudentFound
        {

            get
            {

                return studentFound;

            }// get

        }// public bool StudentFound
        public string UserInput
        {

            set
            {

                userInput = value;

            }// set

        }// public string UserInput

    }// public class StudentLogin

}// namespace Example