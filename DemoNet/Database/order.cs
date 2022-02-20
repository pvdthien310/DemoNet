using DemoNet.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNet.Database
{
    class order
    {
        public static MongoClient client = new MongoClient("mongodb+srv://live2022:live2022password@cluster0.ri8is.mongodb.net/testdb?" +
            "retryWrites=true&w=majority");
        public static IMongoDatabase database = client.GetDatabase("testdb");
        public static IMongoCollection<Order> collection = database.GetCollection<Order>("order");

        public static List<Order> GetOrders()
        {
            return collection.Find(FilterDefinition<Order>.Empty).ToList();
        }

        public static bool AddOrders(Order order)
        {
            collection.InsertOne(order);
            return true;
        }
    }
}
