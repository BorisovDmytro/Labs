using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Lab6
{
  [BsonIgnoreExtraElements]
  public class Product : MongoEntity
  {
    public Product()
    {
      //this.Id = ObjectId.GenerateNewId();
    }

    public Product(string Name, string Manufacturer, double Price, string SellerId)
    {
      //this.Id = ObjectId.GenerateNewId();
      this.Name = Name;
      this.Manufacturer = Manufacturer;
      this.SellerId = new ObjectId(SellerId);
      this.Price = Price;
    }

    public ObjectId SellerId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public double Price { get; set; }
  }
}

