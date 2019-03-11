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


namespace HouseKeeping_Management_System
{
    /// <summary>
    /// Interaction logic for Employer_Dashboard.xaml
    /// </summary>
    public partial class Employer_Dashboard : Window
    {
        public Employer_Dashboard()
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
        private void Search_Employee(object sender, RoutedEventArgs e)
        {
            Search_Employee se = new Search_Employee();
            se.Show();
            this.Close();
        }

        private void Update_Profile(object sender, RoutedEventArgs e)
        {
            Update_Employer_Profile um = new Update_Employer_Profile();
            um.Show();
            this.Close();
        }

        
    }
}
