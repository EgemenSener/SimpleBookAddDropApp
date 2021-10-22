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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
       

        public Window2()
        {
            InitializeComponent();

            
        }
        
        
        public void Adventure_Selected(object sender, RoutedEventArgs e)
        {
            combo_2.Items.Clear();
            combo_2.Items.Add("Jungle Book");
            combo_2.Items.Add("Treasure Island");
            combo_2.Items.Add("Lost World");
        }

        public void Classics_Selected(object sender, RoutedEventArgs e)
        {
            combo_2.Items.Clear();
            combo_2.Items.Add("Jane Eyre");
            combo_2.Items.Add("Great Expectations");
            combo_2.Items.Add("The Call of the Wild");
        }

        public void Science_Fiction_Selected(object sender, RoutedEventArgs e)
        {
            combo_2.Items.Clear();
            combo_2.Items.Add("Lord of The Rings");
            combo_2.Items.Add("I, Robot");
            combo_2.Items.Add("Solaris");
        }

       
      
    
       

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            next.IsEnabled = false;
        }



        private void Confirm_Checked(object sender, RoutedEventArgs e)
        {
            next.IsEnabled = true;
        }

        private void Confirm_Unchecked(object sender, RoutedEventArgs e)
        {
            next.IsEnabled = false;
        }

        public static ObservableCollection<String> dizi4 = new ObservableCollection<string>();

        public void next_Click(object sender, RoutedEventArgs e)
        {
            Window4 objWindow4 = new Window4();
            this.Visibility = Visibility.Hidden;
            //It provides hidden window2 
            objWindow4.Show();                              //It provides open window4 
            
        }
        
        private void book_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected Book added!");
            dizi4.Add(combo_2.Text);


        }
        
}
}
