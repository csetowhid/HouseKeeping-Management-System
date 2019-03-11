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
    /// Interaction logic for Employee_Dashboard.xaml
    /// </summary>
    public partial class Employee_Dashboard : Window
    {
        public Employee_Dashboard()
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

        private void Delete(object sender, RoutedEventArgs e)
        {
            Delete_Employee_Account ds = new Delete_Employee_Account();
            ds.Show();
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
