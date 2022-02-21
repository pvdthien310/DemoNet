using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoNet.Model
{
    class OrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string name;
        [BsonElement("name")]
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string imgSource;
        [BsonElement("imgSource")]
        public string ImgSource
        {
            get { return imgSource; }
            set
            {
                imgSource = value;
                OnPropertyChanged("ImgSource");
            }
        }
        private int price;
        [BsonElement("price")]
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        private int amount;
        [BsonElement("amount")]
        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                Total = amount * price;
                OnPropertyChanged("Amount");
            }
        }
        private int total;

        public OrderItem(Product product)
        {
            Name = product.Name;
            ImgSource = product.ImgSource;
            Price = product.Price;
            Amount = 1;
            Total = product.Price;
        }

        [BsonElement("total")]
        public int Total
        {
            get { return total; }
            set
            {
                total = value;
                OnPropertyChanged("Total");
            }
        }
    }
}
