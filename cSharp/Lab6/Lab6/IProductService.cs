
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Lab6
{
  public abstract class IProductService : EntityService<Product>
  {
    public IProductService(MongoCollectionHandler<Product> handler)
      : base(handler) {}

    public abstract List<Product> GetAllSellerProducts(string sellerId);
  }
}
