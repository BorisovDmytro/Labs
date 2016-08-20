using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Lab6
{
  public abstract class EntityService<T> : IEntityServices<T>
    where T : IMongoEntity
  {
    protected MongoCollectionHandler<T> handler;

    public EntityService(MongoCollectionHandler<T> handler)
    {
      this.handler = handler;
    }

    public virtual void Create(T entity)
    {
      handler.Collection.InsertOne(entity);
    }

    public virtual void Delete(string id)
    {
      var filter = Builders<T>.Filter.Eq(x => x.Id, new ObjectId(id));
      handler.Collection.DeleteOne(filter);
    }

    public virtual T GetById(string id)
    {
      var filter = Builders<T>.Filter.Eq(x => x.Id, new ObjectId(id));
      var list = handler.Collection.FindSync<T>(filter).ToList<T>();
      if (list.Count == 0)
        return default(T);
      return list[0];
    }

    public abstract void Update(T entity);

    public virtual List<T> GetAll()
    {
      var filter = Builders<T>.Filter.Empty;
      return handler.Collection.FindSync(filter).ToListAsync().Result;
    }
  }
}
