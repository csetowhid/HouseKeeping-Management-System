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
    /// Interaction logic for Employer_Sign_Up.xaml
    /// </summary>
    public partial class Employer_Sign_Up : Window
    {
       
        public Employer_Sign_Up()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeft(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
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
            string fullname, username, email, password, phn, add, bld, marry, gender, dob, nid;

            fullname = txt_fullname.Text;
            username = txtusername.Text;
            email = txtemail.Text;
            password = pbpass.Password;
            phn = txtphone.Text;
            add = txtadd.Text;
            bld = txtblood.Text;
            nid = textnid.Text;

            if (chkms.IsChecked.Value == true)
            {
                marry = "Yes";
            }
            else
            {
                marry = "No";
            }
            if (rdomale.IsChecked.Value == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            var a = (ComboBoxItem)cmd_reg.SelectedItem;
            string rel = (String)a.Content;

            dob = dpdob.SelectedDate.Value.ToShortDateString();
            string connectionstring = @"Data Source=DESKTOP-1A5KDLM;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into Employer(fullname,username,email,password,phn,address,bld,nid,ms,gender,dob,rel) values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = fullname;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = phn;
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = add;
            cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = bld;
            cmd.Parameters.Add("@h", SqlDbType.VarChar).Value = nid;
            cmd.Parameters.Add("@i", SqlDbType.VarChar).Value = marry;
            cmd.Parameters.Add("@j", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@k", SqlDbType.Date).Value = dob;
            cmd.Parameters.Add("@l", SqlDbType.VarChar).Value = rel;

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Account Created Successfully");
            sqlcon.Close();
        }

        private void btn_reset(object sender, RoutedEventArgs e)
        {
            txt_fullname.Clear();
            txtusername.Clear();
            txtemail.Clear();
            pbpass.Clear();
            txtphone.Clear();
            txtadd.Clear();
            txtblood.Clear();
            textnid.Clear();
            cmd_reg.Text = "";
            dpdob.Text = "";
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void sign(object sender, RoutedEventArgs e)
        {
            Sign_In si = new Sign_In();
            si.Show();
            this.Close();
        }
    }
}
