using StoreApp.Models;
using StoreApp.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        private Product _Product { get; set; } = new();
        public Product Product { get => _Product;
            set
            {
                _Product=value;
                NotifyPropertyChanged();
            }
                }
        public ObservableCollection<Product> ProductList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            ProductList=new ObservableCollection<Product>();
            Product=new Product() { Image = new BitmapImage(new Uri("https://www.bakenroll.az/en/image/coca-cola.jpg")), Name="Cola", Price=12 };
            ProductList.Add(Product);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();
            
        }
    }
}