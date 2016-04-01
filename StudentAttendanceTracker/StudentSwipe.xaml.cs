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
using System.Windows.Threading;
using MySql.Data.MySqlClient;
/*Allows developers to add functionality to UI objects. Comment Updated: 3/30/2016.*/
namespace StudentAttendanceTracker
{
    /// <summary>
    /// Interaction logic for StudentSwipe.xaml
    /// </summary>
    public partial class StudentSwipe : Window
    {

        private System.Timers.Timer successTimer;
        private string studentInputVariable = "";
        private static readonly DispatcherTimer timer;
        TimeStamp dateVariable = new TimeStamp();
        StudentIDNumber studentVariable = new StudentIDNumber();
        StudentLogin loginVariable = new StudentLogin();
        bool justSwiped;
        DialogBox dialog;
        static StudentSwipe()
        {

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);

        }// static StudentSwipe()
        public StudentSwipe()
        {

            InitializeComponent();
            justSwiped = false;
            timer.Tick += timeDelay;
            successTimer = new System.Timers.Timer(3000);
            Console.WriteLine(student_instruction_block.Text);
            student_instruction_block.Visibility = Visibility.Visible;
            student_ID_input_box.Focus();
            dialog = new DialogBox();

        }// public StudentSwipe
        // Button used to return to the menu screen. Comment updated 3/30/2016.
        private void go_back_button_Click(object sender, RoutedEventArgs e)
        {

            homeScreen homeScreenWindow = new homeScreen();
            homeScreenWindow.Show();
            this.Close();

        }// private void go_back_button_Click(object sender, RoutedEventArgs e)
        // Textbox used to input ID swipe. Comment updated 3/25/2016.
        private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)
        {

            TextBox textInfomationVariable = sender as TextBox;
            studentInputVariable = textInfomationVariable.Text;
            if (studentInputVariable.Length == 18 && !justSwiped)
            {

                studentInputVariable = studentVariable.retrieveStudentId(studentInputVariable);
                studentInputVariable = studentInputVariable + " " + dateVariable.GetDate(DateTime.Today);
                studentInputVariable = studentInputVariable + " " + dateVariable.GetTimestamp(DateTime.Now);
                loginVariable.UserInput = studentInputVariable;
                loginVariable.databaseLoginCheck();
                dialog.UserInput = studentInputVariable;
                dialog.studentSwipesLogged();
                dialog.ShowDialog();
                System.IO.File.WriteAllText(@"C:\Users\gameCoder\Desktop\WriteText.txt", studentInputVariable);
                student_ID_input_box.Clear();
                if (loginVariable.StudentFound)
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

        }// private void timeDelay(object sender, EventArgs e)
        // Closes the Dialogbox that is opened for blog datebase testing. Comment Updated 3/30/2016. 
        private void StudentSwipe_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            dialog.UserInput = "";
            dialog.Close();
        }
    }// public partial class MainWindow : Window

}// namespace StudentAttendanceTracker
