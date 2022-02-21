using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNet.Model
{
    class Account
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("username")]
        public String Username { get; set; }
        [BsonElement("password")]
        public String Password { get; set; }
        public Account(String username, String password)
        {
            Username = username;
            Password = password;
        }
    }
}
