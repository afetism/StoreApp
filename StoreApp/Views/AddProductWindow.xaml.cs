using StoreApp.Models;
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

namespace StoreApp.Views
{
    /// <summary>
    /// Interaction logic for AddProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {

        public Product Product{ get;set;}
        public AddProductWindow()
        {
            InitializeComponent();
        }

      

        private void Button_Click_ADD(object sender, RoutedEventArgs e)
        {
            MainWindow main= new MainWindow();
            main.ProductList.Add(Product);
            MessageBox.Show("Added");
        }
    }
}
