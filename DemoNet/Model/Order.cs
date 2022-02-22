using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace DemoNet.Model
{
    class Order
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        [BsonId]
        private ObjectId id;
        public ObjectId Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
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
        private string phoneNumber;
        [BsonElement("phoneNumber")]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        private DateTime date;
        [BsonElement("createdDate")]
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        private ObservableCollection<OrderItem> listProduct;
        [BsonElement("orderItems")]
        public ObservableCollection<OrderItem> ListProduct
        {
            get { return listProduct; }
            set
            {
                listProduct = value;
                OnPropertyChanged("ListProduct");
            }
        }

        private int total;

        public Order(ObservableCollection<OrderItem> listProduct, int total, string name, string number)
        {
            this.date = DateTime.Now;
            ListProduct = listProduct;
            Total = total;
            Name = name;
            PhoneNumber = number;
        }

        [BsonElement("totalPrice")]
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
