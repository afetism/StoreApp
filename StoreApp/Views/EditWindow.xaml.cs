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
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public Product Product { get; set; } = new();
        public EditWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click_Edit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit Item");
            DialogResult = true;
        }
    }
}
