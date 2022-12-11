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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace STB_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {
            //////
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow objLogInWindow = new LogInWindow();
            this.Visibility = Visibility.Hidden;
            objLogInWindow.Show();
        }

        private void register_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow objRegisterWindow = new RegisterWindow();
            this.Visibility = Visibility.Hidden;
            objRegisterWindow.Show();
        }
    }
}