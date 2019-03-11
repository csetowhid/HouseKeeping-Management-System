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
using System.Data;
using System.Data.SqlClient;

namespace HouseKeeping_Management_System
{
    /// <summary>
    /// Interaction logic for Delete_Employer_Account.xaml
    /// </summary>
    public partial class Delete_Employer_Account : Window
    {
        public Delete_Employer_Account()
        {
            InitializeComponent();
        }

        private void grid(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btn_delete(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-1A5KDLM;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            string commandstring = "delete from dbo.Employer where username= @a";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcmd.Parameters.Add("@a", SqlDbType.VarChar).Value =txtusername.Text;
            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();

            if (rows > 0)
            MessageBox.Show("Account Deleted.");
        }
    }
    }

