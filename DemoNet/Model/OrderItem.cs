using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNet.Model
{
    public class OrderItem
    {
        [BsonElement("name")]
        public String Name { get; set; }
        [BsonElement("price")]
        public int Price { get; set; }
        [BsonElement("amount")]
        public int Amount { get; set; }
        [BsonElement("total")]
        public int Total { get; set; }
        [BsonElement("imgSource")]
        public String ImgSource { get; set; }

        public OrderItem(String name, int price, int amout, int total, String imgSource)
        {
            Name = name;
            Price = price;
            Amount = amout;
            Total = total;
            ImgSource = imgSource;
        }
    }
}
