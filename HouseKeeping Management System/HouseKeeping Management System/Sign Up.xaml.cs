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
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Window
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void employer_signup(object sender, RoutedEventArgs e)
        {
            Employer_Sign_Up es = new Employer_Sign_Up();
            es.Show();
            this.Close();
        }

        private void employee_signup(object sender, RoutedEventArgs e)
        {
            Employee_Sign_Up es = new Employee_Sign_Up();
            es.Show();
            this.Close();
        }

        private void grid(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
