using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Lab6
{
  public class MongoCollectionHandler<T> where T : IMongoEntity
  {
    public IMongoCollection<T> Collection { get; private set; }

    public MongoCollectionHandler(IMongoDatabase database)
    {
      Collection = database.GetCollection<T>(typeof(T).Name.ToLower() + "type");
    }
  }
}
