using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace lab4mongo.Entities
{
  [BsonIgnoreExtraElements]
  public class Seller : MongoEntity
  {
    public Seller()
    {
      
    }

    public Seller(string Name, string SecondName, int Age)
    {
      this.Name = Name;
      this.SecondName = SecondName;
      this.Age = Age;
    }

    public string Name { get; set; }
 
    public string SecondName { get; set; }

    public int Age { get; set; }
  }
}
