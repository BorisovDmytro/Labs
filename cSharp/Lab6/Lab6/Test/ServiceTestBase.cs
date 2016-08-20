using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Test
{
  using MongoDB.Bson;
  public abstract class ServiceTestBase
  {
    protected ManagerDb manager;
    protected IProductService productService;
    protected ISellerService sellerService;
    protected Seller seller;
    protected Product product;

    public ServiceTestBase()
    {
      manager = new ManagerDb();
      manager.Connect("mongodb://localhost:27017", "test1");
      productService = manager.Factory.CreateProductService();
      sellerService = manager.Factory.CreateSellerService();
    }

    public void RunTest()
    {
      CreateTest();
      UpdateTest();
      DeleteTest();
    }
    public abstract void CreateTest();
    public abstract void UpdateTest();
    public abstract void DeleteTest();
  }
}
