using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab6
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      string data = null;
      Assert.IsNull(data);
    }
  }
}
