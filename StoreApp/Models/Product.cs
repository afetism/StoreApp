using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace StoreApp.Models
{
    public class Product : INotifyPropertyChanged
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        private ImageSource _image;
        public ImageSource Image
        {
            get => _image;
            set
            {
                _image = value;
                NotifyPropertyChanged(nameof(Image));
            }
        }
        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                NotifyPropertyChanged(nameof(Price));
            }
        }


        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
                NotifyPropertyChanged(nameof(Name));
            }
        }

        private string _About;
        public string About
        {
            get => _About;
            set
            {
                _About = value;
                NotifyPropertyChanged(nameof(About));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
