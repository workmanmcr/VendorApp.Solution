using System.Collections.Generic;
using VendorApp.Models;

namespace VendorApp.Tests
{
  [TestClass]
  public class OrderTests
  {
    public class OrderTest : IDisposable
    {

      public void Dispose()
      {
        Order.ClearAll(); // Tests go here
      }
    }
     [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order() 
    {
      Order newOrder = new Order ("test","test",5,1,"bob",2);
      Assert.AreEqual (typeof (Order), newOrder.GetType ());
    }
  }

}