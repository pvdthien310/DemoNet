using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DemoNet.Model
{
    class Product
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
        [BsonElement("Name")]
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
        [BsonElement("ImageSource")]
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
        [BsonElement("Price")]
        public int Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        private int remainning;
        [BsonElement("Remaining")]
        public int Remainning
        {
            get { return remainning; }
            set
            {
                remainning = value;
                OnPropertyChanged("Remainning");
            }
        }

        public Product(string name, string imgSource, int price, int remainning)
        {
            Name = name;
            ImgSource = imgSource;
            Price = price;
            Remainning = remainning;
        }
    }
}
