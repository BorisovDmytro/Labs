using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab6.Test
{
  [TestClass]
  public class ConnectTest
  {
    private ManagerDb manager;

    [TestMethod]
    public void TestConenct()
    {
      manager = new ManagerDb();
      manager.Connect("mongodb://localhost:27017", "test1");
      Assert.IsNotNull(manager.Factory);
    }
  }
}
