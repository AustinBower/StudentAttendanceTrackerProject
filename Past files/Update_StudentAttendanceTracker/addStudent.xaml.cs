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
            SqlConnection connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
            SqlCommand studentCommand = new SqlCommand("SELECT COUNT(*) FROM StudentInfo WHERE StudentNumber = '" + studentID.Text + "'", connectionVariable);
            try
            {
                connectionVariable.Open();
                int totalCount = Convert.ToInt32(studentCommand.ExecuteScalar());
                string studentIDValue = studentID.Text;
                if (totalCount == 0 && studentIDValue.Length == 9)
                {
                    studentCommand = new SqlCommand("INSERT INTO StudentInfo ([StudentNumber], [StudentName], [CourseID]) SELECT'" + studentID.Text + "','" + studentName.Text + "', CourseID FROM CourseInfo WHERE CRN = '" + txtCRN.Text + "'", connectionVariable);
                    studentCommand.ExecuteNonQuery();
                    
                    MessageBox.Show("Success");
                    connectionVariable.Close();
                }
                else
                {
                    MessageBox.Show("Student ID already exists!");
                    connectionVariable.Close();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Query execution error");
            }            
        }

        private void Student_Name_Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
