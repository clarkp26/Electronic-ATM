using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_ATM.Properties;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace E_ATM
{
    class MongodbClass
    {
        //public static MongoClient client = new MongoClient("mongodb://127.0.0.1:27017");
        public IMongoDatabase Database; //= client.GetDatabase("E_ATM_Database");

        public IMongoCollection<BsonDocument> BankAccounts  => Database.GetCollection<BsonDocument>("BankAccounts");
        
        public MongodbClass()
        {
            var client = new MongoClient("mongodb://127.0.0.1:27017");
            //TestConnection(client);
            Database = client.GetDatabase("E_ATM_Database");
            

        }
        public  void returnDBObject()
        {
            var query_pin = Builders<BsonDocument>.Filter.Eq("Pin", 56789);
            var doc = BankAccounts.Find(query_pin).FirstOrDefault();
            //var ATMObject = BankAccounts.Find(new BsonDocument()).FirstOrDefault();
            
            //Console.WriteLine(ATMObject.ToString());
            Console.WriteLine(doc.GetValue("FirstName"));
        }
    }
}
