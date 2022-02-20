using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNet.Model
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Name")]
        public String Name { get; set; }
        [BsonElement("Price")]
        public int Price { get; set; }
        [BsonElement("ImageSource")]
        public String ImageSource { get; set; }
        [BsonElement("Remaining")]
        public int Remaining { get; set; }
        public Product(String name, int price, String imageSource, int remaining)
        {
            Name = name;
            Price = price;
            ImageSource = imageSource;
            Remaining = remaining;
        }
        public Product() { }
    }
}
