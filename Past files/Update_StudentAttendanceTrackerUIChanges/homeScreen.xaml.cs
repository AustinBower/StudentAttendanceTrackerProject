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
    /// Interaction logic for homeScreen.xaml
    /// </summary>
    public partial class homeScreen : Window
    {

        public homeScreen()
        {
            InitializeComponent();
        }
        private void addCourseButton_Click(object sender, RoutedEventArgs e)
        {
            addCourse addCourseWindow = new addCourse();
            addCourseWindow.Show();
            this.Close();
        }

        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            addStudent addStudentWindow = new addStudent();
            addStudentWindow.Show();
            this.Close();
        }

        //close the home window and go back to the welcome window
        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            * Add a check to make sure that the user wants to exit
            */
            MainWindow welcome = new MainWindow();
            welcome.Show();
            this.Close();
        }
       

        private void addCoursesButton_Click(object sender, RoutedEventArgs e)
        {
            addCourse addCourseWindow = new addCourse();
            addCourseWindow.Show();
            this.Close();
        }

        private void Course_comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             /*       
            
           */
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
            try
            {
                 connectionVariable.Open();
                SqlCommand courseCommand = new SqlCommand("SELECT CourseName FROM CourseInfo", connectionVariable);
                SqlDataReader reader = courseCommand.ExecuteReader();
                while (reader.Read())
                {
                    Course_comboBox.Items.Add(reader["CourseName"]);
                }
                reader.Close();
                connectionVariable.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LoadTableButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connectionVariable = new SqlConnection(@"Data Source=YINGJUN\SQLEXPRESS;Initial Catalog=StudentAttendanceTracker;Integrated Security=True");
            try
            {
                connectionVariable.Open();
                SqlCommand courseCommand = new SqlCommand("select CourseName, StudentName, Attendances from StudentInfo join CourseInfo on CourseInfo.CourseID = StudentInfo.CourseID", connectionVariable);
                courseCommand.ExecuteNonQuery();
                SqlDataAdapter attendance = new SqlDataAdapter(courseCommand);
                DataTable check = new DataTable("StudentInfo");
                attendance.Fill(check);
                dataGrid.ItemsSource = check.DefaultView;
                attendance.Update(check);
                connectionVariable.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
    }

}
