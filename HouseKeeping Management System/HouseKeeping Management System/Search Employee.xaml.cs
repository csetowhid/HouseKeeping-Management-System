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
using System.Data;
using System.Data.SqlClient;

namespace HouseKeeping_Management_System
{
    /// <summary>
    /// Interaction logic for Search_Employee.xaml
    /// </summary>
    public partial class Search_Employee : Window
    {
        public Search_Employee()
        {
            InitializeComponent();
        }

        private void btn_search(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-1A5KDLM;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.Employee where address='" + txtadd.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                txt_details.Text = "Full Name : " + read[0].ToString();
                txt_details.Text += "\n User Name : " + read[1].ToString();
                txt_details.Text += "\nEmail : " + read[2].ToString();
                txt_details.Text += "\nPhone : " + read[4].ToString();
                txt_details.Text += "\nNid : " + read[7].ToString();
                txt_details.Text += "\nMarry : " + read[8].ToString();
                txt_details.Text += "\n Religion : " + read[11].ToString();
            }
            sqlcon.Close();
        }

        private void Grid_MouseLeft(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
