using StoreApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for BasketWindow.xaml
    /// </summary>
    public partial class BasketWindow : Window,INotifyPropertyChanged
    {

        private Product _Product { get; set; } = new();
        public Product Product
        {
            get => _Product;
            set
            {
                _Product = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<DTOProduct> ProductList { get; set; } = new();


        private int _Count { get; set; } = 1;
        public int Count
        {
            get => _Count;
            set
            {
                _Count = value;
                NotifyPropertyChanged();
            }
        }
        public BasketWindow()
        {
            InitializeComponent();
            DataContext = this;
        }



        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
