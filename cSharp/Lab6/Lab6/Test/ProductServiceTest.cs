using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;

namespace Lab6.Test
{
  [TestClass]
  public class ProductServiceTest : ServiceTestBase
  {
    public ProductServiceTest() : base()
    {
      seller = sellerService.GetAll()[0];
    }

    [TestMethod]
    public void MainTestProduct()
    {
      RunTest();
    }

    public override void CreateTest()
    {
      product = new Product("NAME", "MANUFACTURER", 1.0, seller.Id.ToString());
      productService.Create(product);
      Product productCreated = productService.GetById(product.Id.ToString());

      Assert.IsNotNull(productCreated);

      Assert.AreEqual(product.Name, productCreated.Name);
      Assert.AreEqual(product.Manufacturer, productCreated.Manufacturer);
      Assert.AreEqual(product.Price, productCreated.Price);
    }

    public override void UpdateTest()
    {
      product.Name = "NEWNAME";
      product.Manufacturer = "NEWMANUFACTURER";
      product.Price = 10.0;

      productService.Update(product);
      Product productUpdate = productService.GetById(product.Id.ToString());

      Assert.IsNotNull(productUpdate);

      Assert.AreEqual(product.Name, productUpdate.Name);
      Assert.AreEqual(product.Manufacturer, productUpdate.Manufacturer);
      Assert.AreEqual(product.Price, productUpdate.Price);
    }

    public override void DeleteTest()
    {
      productService.Delete(product.Id.ToString());
      Product productDelete = productService.GetById(product.Id.ToString());

      Assert.IsNull(productDelete);
    }
  }
}
