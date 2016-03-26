using System.Data.SqlClient;
using System.Data;
using System;
using MySql.Data.MySqlClient;
/*This class accesses the database and checks to see if the information swiped in is a current student
in the class. If the swipe is valid, the date and time are inputted into the database.
Comment updated 3/25/2016.*/
namespace Example
{

    public class StudentLogin
    {

        private MySqlConnection connectionVariable;
        private MySqlCommand searchCommand;
        private bool studentFound = false;
        private string studentIdSubstring;
        private string dateSubstring;
        private string timeSubstring;
        // Takes studentId information from string and checks it against known IDs in the database. Comment updated 3/25/2016.
        public void databaseLoginCheck(string userInput)
        {

            studentIdSubstring = userInput.Substring(0, 9);
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            connectionVariable.Open();
            searchCommand = new MySqlCommand("SELECT * FROM student WHERE StudentNumber = " + studentIdSubstring, connectionVariable);
            MySqlDataReader reader = searchCommand.ExecuteReader();
            if(reader.HasRows)
            {

                studentFound = true;

            }// if(reader.HasRows)

        }// public bool databaseLoginCheck(string userInput)
        public bool StudentFound
        {

            get
            {

                return studentFound;

            }// get

        }// public bool StudentFound


    }// public class StudentLogin

}// namespace Example