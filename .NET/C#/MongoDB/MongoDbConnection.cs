using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("MyDB");
var collection = database.GetCollection<Order>("orders");
