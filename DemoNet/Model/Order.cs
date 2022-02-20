using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNet.Model
{
    public class Order
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("orderItems")]
        public List<OrderItem> OrderItems { get; set; }
        [BsonElement("createdDate")]
        public DateTime Date { get; set; }
        [BsonElement("totalPrice")]
        public int TotalPrice { get; set; }
    }
}
