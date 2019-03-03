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
                this.Close();
        }

        private void btn_sign(object sender, RoutedEventArgs e)
        {
            string fullname,username,userid,email,password, phn,add,bld,marry, gender, dob,nid;
            
            fullname = txt_fullname.Text;
            username = txtusername.Text;
            userid = txtuserid.Text;
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
            // MessageBox.Show(fullname+ "\n" + rel + "\n" + dob);
            string connectionstring = @"Data Source=DESKTOP-1A5KDLM;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into hms(fullname,username,userid,email,password,phn,address,bld,nid,ms,gender,dob,rel) values(@a,@b,@c,@d,@e,@f,@g,@g,@i,@j,@k,@l,@m)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = fullname;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = userid;
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = password;
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = phn;
            cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = add;
            cmd.Parameters.Add("@h", SqlDbType.VarChar).Value = bld;
            cmd.Parameters.Add("@i", SqlDbType.VarChar).Value = nid;
            cmd.Parameters.Add("@j", SqlDbType.VarChar).Value = marry;
            cmd.Parameters.Add("@k", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@l", SqlDbType.Date).Value = dob;
            cmd.Parameters.Add("@m", SqlDbType.VarChar).Value = rel;

            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Account Created Successfully");
            sqlcon.Close();
        }
    }
}
