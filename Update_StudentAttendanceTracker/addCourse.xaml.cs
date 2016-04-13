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
    /// Interaction logic for addCourse.xaml
    /// </summary>
    public partial class addCourse : Window
    {
        public addCourse()
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
            SqlCommand studentCommand = new SqlCommand("SELECT COUNT(*) FROM CourseInfo WHERE CRN = '" + addCourseCRN.Text + "'", connectionVariable);
            try
            {
                connectionVariable.Open();
                int totalCount = Convert.ToInt32(studentCommand.ExecuteScalar());
                string studentIDValue = addCourseCRN.Text;
                if (totalCount == 0 && studentIDValue.Length == 5)
                {
                    studentCommand = new SqlCommand("INSERT INTO CourseInfo ([CRN], [CourseName]) VALUES('" + addCourseCRN.Text + "','" + courseName.Text + "')", connectionVariable);
                    studentCommand.ExecuteNonQuery();
                    MessageBox.Show("Success");
                    connectionVariable.Close();
                }
                else
                {
                    MessageBox.Show("CRN already exists!");
                    connectionVariable.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Query execution error");
            }
        }
    }
}
