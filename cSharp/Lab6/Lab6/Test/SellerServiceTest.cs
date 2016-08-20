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
  public class SellerServiceTest : ServiceTestBase
  {

    public SellerServiceTest() : base()
    {
      
    }

    public override void CreateTest()
    {
      seller = new Seller("NAME", "SECOND", 1);
      sellerService.Create(seller);
      Seller sellerCreate = sellerService.GetById(seller.Id.ToString());

      Assert.IsNotNull(sellerCreate);

      Assert.AreEqual(seller.Name, sellerCreate.Name);
      Assert.AreEqual(seller.SecondName, sellerCreate.SecondName);
      Assert.AreEqual(seller.Age, sellerCreate.Age);
    }

    public override void DeleteTest()
    {
      sellerService.Delete(seller.Id.ToString());
      Seller deleteSeller = sellerService.GetById(seller.Id.ToString());

      Assert.IsNull(deleteSeller);
    }

    [TestMethod]
    public void MainSellerServiceTest()
    {
      RunTest();
    }

    public override void UpdateTest()
    {
      seller.Name = "NEWNAME";
      seller.SecondName = "NEWSECOND";
      seller.Age = 10;
      sellerService.Update(seller);
      Seller sellerUpdate = sellerService.GetById(seller.Id.ToString());

      Assert.IsNotNull(sellerService);

      Assert.AreEqual(seller.Name, sellerUpdate.Name);
      Assert.AreEqual(seller.SecondName, sellerUpdate.SecondName);
      Assert.AreEqual(seller.Age, sellerUpdate.Age);
    }
  }
}
