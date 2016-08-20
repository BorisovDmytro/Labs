using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
  public class ServiceFactoryImpl : IServiceFactory
  {
    protected IMongoDatabase database;

    public ServiceFactoryImpl(IMongoDatabase db)
    {
      database = db;
    }

    public IProductService CreateProductService()
    {
      return new ProductServiceImpl(new MongoCollectionHandler<Product>(database));
    }

    public ISellerService CreateSellerService()
    {
      return new SelllerServiceImpl(new MongoCollectionHandler<Seller>(database));
    }
  }
}
