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

namespace Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string studentInputVariable = "";
        TimeStamp dateVariable = new TimeStamp();
        StudentIDNumber studentVariable = new StudentIDNumber();
        public MainWindow()
        {

            InitializeComponent();
            student_ID_input_box.Focus();

        }// public MainWindow

        private void go_back_button_Click(object sender, RoutedEventArgs e)
        {


            Application curApp = Application.Current;
            curApp.Shutdown();

        }// private void go_back_button_Click(object sender, RoutedEventArgs e)

        private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)
        {

            TextBox textInfomationVariable = sender as TextBox;
            studentInputVariable = textInfomationVariable.Text;
            if (studentInputVariable.Length == 18)
            {

                studentInputVariable = studentVariable.retrieveStudentId(studentInputVariable);
                studentInputVariable = studentInputVariable + " " + dateVariable.GetDate(DateTime.Today);
                studentInputVariable = studentInputVariable + " " + dateVariable.GetTimestamp(DateTime.Now);
                System.IO.File.WriteAllText(@"C:\Users\gameCoder\Desktop\WriteText.txt", studentInputVariable);
                student_ID_input_box.Clear();

            }// if(studentInputVariable.Length == 18)

        }// private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)

    }// public partial class MainWindow : Window

}// namespace Example
