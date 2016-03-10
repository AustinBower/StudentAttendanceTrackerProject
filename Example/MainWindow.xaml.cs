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
using System.IO;
using System.Diagnostics;
using System.Windows.Threading;

namespace Example
{
    public class StringWrapper
    {
        public string bindingString
        {
            get; set;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Timers.Timer successTimer;
        private string studentInputVariable = "";
        private static readonly DispatcherTimer timer;
        TimeStamp dateVariable = new TimeStamp();
        StudentIDNumber studentVariable = new StudentIDNumber();

        bool justSwiped;

        static MainWindow()
        {

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
        }

        public MainWindow()
        {

            justSwiped = false;
            InitializeComponent();
            timer.Tick += timeDelay;
            successTimer = new System.Timers.Timer(3000);
            Console.WriteLine(student_instruction_block.Text);
            student_instruction_block.Visibility = Visibility.Visible;
            student_ID_input_box.Focus();

        }// public MainWindow

        private void go_back_button_Click(object sender, RoutedEventArgs e)
        {

            //Console.WriteLine(student_instruction_block.Text);

            Application curApp = Application.Current;
            curApp.Shutdown();

        }// private void go_back_button_Click(object sender, RoutedEventArgs e)

        private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            TextBox textInfomationVariable = sender as TextBox;
            studentInputVariable = textInfomationVariable.Text;
            if (studentInputVariable.Length >= 18 && !justSwiped)
            {

                studentInputVariable = studentVariable.retrieveStudentId(studentInputVariable);
                studentInputVariable = studentInputVariable + " " + dateVariable.GetDate(DateTime.Today);
                studentInputVariable = studentInputVariable + " " + dateVariable.GetTimestamp(DateTime.Now);
                System.IO.File.WriteAllText(@"C:\Users\gameCoder\Desktop\WriteText.txt", studentInputVariable);
                student_ID_input_box.Clear();
                student_instruction_block.Text = "Successful Swipe!";
                go_back_button.Visibility = Visibility.Collapsed;
                timer.Start();
                justSwiped = true;

            }// if (studentInputVariable.Length == 18)

        }// private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)

        public void timeDelay(object sender, EventArgs e)
        {

            if(justSwiped)
            {
                justSwiped = false;
                student_instruction_block.Text = "Please swipe ID card:";
                go_back_button.Visibility = Visibility.Visible;
                timer.Stop();
            }

        }

    }// public partial class MainWindow : Window

}// namespace Example
