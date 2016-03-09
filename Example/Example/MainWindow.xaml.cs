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
using System.Threading;

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

        public StringWrapper wrapper;
        private string studentInputVariable = "";
        TimeStamp dateVariable = new TimeStamp();
        StudentIDNumber studentVariable = new StudentIDNumber();
        public MainWindow()
        {

            wrapper = new StringWrapper();
            Console.WriteLine(wrapper.bindingString);
            InitializeComponent();
            Console.WriteLine(student_instruction_block.Text);
            student_instruction_block.Visibility = Visibility.Visible;
            wrapper.bindingString = "Please swipe ID Card";
            student_ID_input_box.Focus();
            Binding bind = new Binding("bindingString");
            bind.Source = wrapper;
            bind.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            student_instruction_block.SetBinding(TextBlock.TextProperty, bind);

        }// public MainWindow

        private void go_back_button_Click(object sender, RoutedEventArgs e)
        {

            //Console.WriteLine(student_instruction_block.Text);

            Application curApp = Application.Current;
            curApp.Shutdown();

        }// private void go_back_button_Click(object sender, RoutedEventArgs e)

        private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            BindingExpression bind = student_instruction_block.GetBindingExpression(TextBlock.TextProperty);
            TextBox textInfomationVariable = sender as TextBox;
            studentInputVariable = textInfomationVariable.Text;
            if (studentInputVariable.Length == 18)
            {

                studentInputVariable = studentVariable.retrieveStudentId(studentInputVariable);
                studentInputVariable = studentInputVariable + " " + dateVariable.GetDate(DateTime.Today);
                studentInputVariable = studentInputVariable + " " + dateVariable.GetTimestamp(DateTime.Now);
                System.IO.File.WriteAllText(@"C:\Users\gameCoder\Desktop\WriteText.txt", studentInputVariable);
                student_ID_input_box.Clear();
                wrapper.bindingString = "Successful Swipe";
                bind.UpdateTarget();
                changeDelay();
                wrapper.bindingString = "PleaseSwipe an ID";
                bind.UpdateTarget();

            }// if (studentInputVariable.Length == 18)

        }// private void student_ID_input_box_TextChanged(object sender, TextChangedEventArgs e)

        private void changeDelay()
        {

            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalMilliseconds < 3000)
            {
            }// while((DateTime.Now - startTime).TotalMilliseconds < 3000)

        }// private void changeDelay()

    }// public partial class MainWindow : Window

}// namespace Example
