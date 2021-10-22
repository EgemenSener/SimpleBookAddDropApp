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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (username.Text.Equals ("admin"))
            {
                if (password.Password.Equals("123456"))
                {
                    Window2 objWindow2 = new Window2();
                    this.Visibility = Visibility.Hidden;               //It provides hidden window1
                    objWindow2.Show();                                 //It provides open window2
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
