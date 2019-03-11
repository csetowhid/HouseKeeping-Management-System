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
        private void Search_Employee(object sender, RoutedEventArgs e)
        {
            Search_Employee se = new Search_Employee();
            se.Show();
            this.Close();
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            Sign_In mw = new Sign_In();
            mw.Show();
            this.Close();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            Delete_Employer_Account dm = new Delete_Employer_Account();
            dm.Show();
            this.Close();
    }
    }
}
