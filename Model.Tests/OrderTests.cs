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
     [TestMethod]
    public void GetTitle_ReturnsTitle_String() 
    {
      //Arrange
      string title = "bob's smokehouse";

      //Act
      Order newVendor = new Order (title,"order Croissants",30,1,"bob",2);
      string result = newVendor.Title;

      //Assert
      Assert.AreEqual (title, result);
    }
     [TestMethod]
    public void SetDescription_SetDescription_String () {
      //Arrange
      string description = "croissants.";
      Order newOrder = new Order ("bobs Store",description,30,2,"bob",1);

      //Act
      string updatedDescription = "sourdough bread";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual (updatedDescription, result);
  }
  }

}