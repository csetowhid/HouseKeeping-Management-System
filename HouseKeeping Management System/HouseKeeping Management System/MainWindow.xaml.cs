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

namespace HouseKeeping_Management_System
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

        private void grid_down(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_signup(object sender, RoutedEventArgs e)
        {
            Sign_Up su = new Sign_Up();
            su.Show();
            this.Close();
        }

        private void btn_exit(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButton.YesNo);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    System.Environment.Exit(0);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Thank you!", "Exit");
                    break;
            }
        }

        private void btn_sign(object sender, RoutedEventArgs e)
        {
            Sign_In ai = new Sign_In();
            ai.Show();
            this.Close();
        }
    }
}
