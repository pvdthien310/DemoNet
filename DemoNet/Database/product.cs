using DemoNet.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNet.Database
{
    class product
    {
        public static MongoClient client = new MongoClient("mongodb+srv://live2022:live2022password@cluster0.ri8is.mongodb.net/testdb?" +
           "retryWrites=true&w=majority");
        public static IMongoDatabase database = client.GetDatabase("testdb");
        public static IMongoCollection<Product> collection = database.GetCollection<Product>("product");

        public static List<Product> GetProducts()
        {
            return collection.Find(FilterDefinition<Product>.Empty).ToList();
        }

        public static bool AddProduct(Product p)
        {
            collection.InsertOne(p);
            return true;
        }
    }
}
