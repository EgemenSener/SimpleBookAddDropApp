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
using System.Collections.ObjectModel;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {

       // public List<List2> calclist = new List<List2>();


        /*public class List2
        {
            public string MyProperty { get; set; }

            
        }*/
        

        public Window4()
        {
            InitializeComponent();
           
            foreach(string element in Window2.dizi4)
            {
                listtbox.Items.Add(element.ToString());
            }


           //listtbox.ItemsSource = calclist;
        
        }



        Window2 objWindow2 = new Window2();

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();                     //It provides close application
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Window2 objWindow2 = new Window2();

            this.Visibility = Visibility.Hidden;            //It provides hidden window2 
            objWindow2.Show();       //It provides open window4 
            
            
        }
        
        private void delete_Click(object sender, RoutedEventArgs e)
        {

            
            listtbox.Items.Remove(listtbox.SelectedItem);
           
            

        }

        //private void Grid_Loaded(object sender, RoutedEventArgs e)
        
    }
}
