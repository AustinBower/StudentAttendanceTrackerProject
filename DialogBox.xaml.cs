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
/*UI that allows teachers to open up blog files containing student swipe in time. Comment Updated 3/30/2016.*/
namespace StudentAttendanceTracker
{
    /// <summary>
    /// Interaction logic for DialogBox.xaml
    /// </summary>
    public partial class DialogBox : Window
    {

        private bool personFound;
        private string userInput;
        public string UserInput
        {

            set
            {

                userInput = value;

            }// set

        }// public string UserInput
        public bool PersonFound
        {

            get
            {

                return personFound;

            }// get
            set
            {

                personFound = value;

            }// set

        }// public bool PersonFound
        public DialogBox()
        {
            InitializeComponent();
            Hide();
        }// public DialogBox()
        // Accesses the database student date column and opens up the blob file. Comment updated 3/31/2016.
        public void studentSwipesLogged()
        {

            PersonFound = false;
            MySqlConnection connectionVariable;
            MySqlCommand searchCommand;
            connectionVariable = new MySqlConnection();
            connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
            string findQuery = "SELECT Date FROM student WHERE StudentName ='" + userInput + "';";
            searchCommand = new MySqlCommand(findQuery, connectionVariable);
            connectionVariable.Open();
            MySqlDataReader reader;
            reader = searchCommand.ExecuteReader();
            if(reader.HasRows)
            {

                PersonFound = true;
                reader.Read();
                File_Editor.Text = reader.GetString("Date");
                reader.Close();

            }// if(reader.HasRows)
            else
            {

                MessageBox.Show("Error person was not found.", "Error");
                
            }// else of if(reader.HasRows)

        }// private void studentSwipesLogged()
        // Closes the dialog box UI. Comment updated 3/31/2016.
        private void DialogBox_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (userInput != "")
            {

                PersonFound = false;
                MySqlConnection connectionVariable;
                MySqlCommand updateCommand;
                MySqlDataReader reader;
                connectionVariable = new MySqlConnection();
                connectionVariable.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=swipecard;";
                connectionVariable.Open();
                string query = "UPDATE swipecard.student SET Date = '" + File_Editor.Text + "';";
                updateCommand = new MySqlCommand(query, connectionVariable);
                reader = updateCommand.ExecuteReader();
                reader.Close();
                e.Cancel = true;
                Hide();

            }// if (userInput != "")

        }// private void DialogBox_Closing(object sender, System.ComponentModel.CancelEventArgs e)

    }// public partial class DialogBox : Window

}// namespace Example
