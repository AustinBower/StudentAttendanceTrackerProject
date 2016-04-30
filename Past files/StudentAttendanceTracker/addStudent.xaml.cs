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
    /// Interaction logic for addStudent.xaml
    /// </summary>
    public partial class addStudent : Window
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void addStudentCancel_Click(object sender, RoutedEventArgs e)
        {
            homeScreen homeScreenWindow = new homeScreen();
            homeScreenWindow.Show();
            this.Close();
        }

        private void addStudentSubmit_Click_1(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Initiate");
            MySqlConnection conn;
            MySqlCommand addStudentCommand;
            conn = new MySqlConnection();
            conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=studentinfo;";

            MySqlCommand checkStudentID = new MySqlCommand("SELECT COUNT(*) FROM studentinformation WHERE StudentNumber = '" + studentID.Text + "'", conn);
            try
            {
                conn.Open();
                int totalCount = Convert.ToInt32(checkStudentID.ExecuteScalar());
                string studentIDValue = studentID.Text;
                if (totalCount == 0 && studentIDValue.Length == 9)
                {
                    addStudentCommand = new MySqlCommand("INSERT INTO studentinformation (StudentNumber, StudentName) VALUES('" + studentID.Text + "','" + studentName.Text + "')", conn);
                    //conn.Open();
                    addStudentCommand.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Student ID already exists!");
                    conn.Close();
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Exception");
            }

            /*addStudentCommand = new MySqlCommand("INSERT INTO studentinformation (StudentNumber, StudentName) VALUES('" + studentID.Text + "','" + studentName.Text + "')", conn);
            conn.Open();
            addStudentCommand.ExecuteNonQuery();
            MessageBox.Show("Success");
            conn.Close();*/
        }
    }
}
