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
        public Product Product
        {
            get => _Product;
            set
            {
                _Product = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Product> ProductList { get; set; }

        public ObservableCollection<DTOProduct> BasketList { get; set; } = new();  

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            ProductList = new ObservableCollection<Product>() {
                 new Product() { Image = new BitmapImage(new Uri("https://www.bakenroll.az/en/image/coca-cola.jpg")), Name = "Cola", Price = 3,About="0.5L LIK" },
                 new Product() { Image = new BitmapImage(new Uri("https://www.bakenroll.az/en/image/fanta.jpg")), Name = "Fanta", Price = 3  ,About="0.5L LIK "}
            };
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
            bool? result = addProductWindow.ShowDialog();
            if (result == true)
            {
                ProductList.Add(addProductWindow.Product);
            }



        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EditWindow editWindow = new EditWindow();
            editWindow.Product= (sender as ListBox)?.SelectedItem as Product;
            editWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            editWindow.ShowDialog();
        }


        private void Button_Click_AddBasket(object sender, RoutedEventArgs e)
        {
            var a = ListBox.SelectedItem as Product;
            bool HasProduct = false;
            foreach (var i in BasketList)
            {
                if (i.Product.Id == a.Id)
                { HasProduct = true;
                    i.Count++;  


                }
               
            }
            if (HasProduct)
            {
               
            }
            else
            {
                int count = 1;
                var newDtoProduct = new DTOProduct() { Product = a, Count = count };
                BasketList.Add(newDtoProduct);
            }
            
        }

     

        private void Button_Click_Basket(object sender, RoutedEventArgs e)
        {
            BasketWindow basketWindow = new BasketWindow();
            basketWindow.ProductList = BasketList;
            basketWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            basketWindow.ShowDialog();
        }
    }
    }