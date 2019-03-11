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
    /// Interaction logic for Employer_Sign_In.xaml
    /// </summary>
    public partial class Employer_Sign_In : Window
    {
        public Employer_Sign_In()
        {
            InitializeComponent();
        }

        private void grid(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_sub(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlcon =new SqlConnection(@"Data Source=DESKTOP-1A5KDLM;Initial Catalog=fall16;Integrated Security=True");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                string commandstring = "select COUNT(1) from Employer WHERE username=@username AND password=@password";
                SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@username",txtusername.Text);
                sqlcmd.Parameters.AddWithValue("@password", pbpass.Password);
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if(count == 1)
                {
                    Employer_Dashboard ad = new Employer_Dashboard();
                    ad.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password Not Matched Try Again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
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

        private void Reset(object sender, RoutedEventArgs e)
        {
            txtusername.Clear();
            pbpass.Clear();
        }
    }
}
