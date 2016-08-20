using lab4mongo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4mongo.DataBasesManager;
using MongoDB.Driver;
using MongoDB.Bson;

namespace lab4mongo.services
{
  public abstract class IProductService : EntityService<Product>
  {
    public IProductService(MongoCollectionHandler<Product> handler)
      : base(handler) {}

    public abstract List<Product> GetAllSellerProducts(string sellerId);
  }
}
