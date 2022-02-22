using DemoNet.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNet.Database
{
    class account
    {
        public static MongoClient client = new MongoClient("mongodb+srv://live2022:live2022password@cluster0.ri8is.mongodb.net/testdb?" +
           "retryWrites=true&w=majority");
        public static IMongoDatabase database = client.GetDatabase("testdb");
        public static IMongoCollection<Account> collection = database.GetCollection<Account>("account");
        public static bool FindAccountByUsernameAndPassword(string username, string password)
        {
            Account acc = collection.Find(e => e.Username == username && e.Password == password).FirstOrDefault();
            if (acc != null)
            {
                return true;
            }
            return false;
        }

        public static bool CreateAccountByUsernameAndPassword(string username, string password)
        {
            Account acc = collection.Find(e => e.Username == username).FirstOrDefault();
            if (acc == null)
            {
                Account ac = new Account(username, password);
                collection.InsertOne(ac);
                return true;
            }
            return false;
        }
    }
}
