﻿using System;
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
    /// Interaction logic for registerScreen.xaml
    /// </summary>
    public partial class registerScreen : Window
    {
        public registerScreen()
        {
            InitializeComponent();
        }

        

        private void registerSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            String username = usernameTextBox.Text;
            String firstname = firstnameTextBox.Text;
            String lastname = lastnameTextBox.Text;
            String email = emailTextBox.Text;
            String password = passwordTextBox.Text;
            String confirmPassword = confirmpasswordTextBox.Text;

            if (password == confirmPassword)
            {

            }

        }

        private void registerGoBackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newMain = new MainWindow();
            newMain.Show();
            this.Close();
        }

        
    }
}
