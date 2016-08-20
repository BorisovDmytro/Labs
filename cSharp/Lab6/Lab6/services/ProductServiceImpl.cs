using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4mongo.DataBasesManager;
using MongoDB.Driver;
using lab4mongo.Entities;
using MongoDB.Bson;

namespace lab4mongo.services
{
  public class ProductServiceImpl : IProductService
  {
    public ProductServiceImpl(MongoCollectionHandler<Product> handler)
      : base(handler) {}

    public override List<Product> GetAllSellerProducts(string sellerId)
    {
      var filter = Builders<Product>.Filter.Eq(x => x.SellerId, new ObjectId(sellerId));
      return handler.Collection.FindSync(filter).ToListAsync<Product>().Result;
    }

    public override void Update(Product entity)
    {
      var filter = Builders<Product>.Filter.Eq(x => x.Id, entity.Id);
      var updater = Builders<Product>.Update
                    .Set(x => x.Name, entity.Name)
                    .Set(x => x.Manufacturer, entity.Manufacturer)
                    .Set(x => x.Price, entity.Price);  
    }
  }
}

