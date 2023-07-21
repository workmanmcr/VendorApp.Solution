using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorApp.Models;

namespace VendorApp.Tests
{
  [TestClass]
  public class VendorTests :IDisposable {
     public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "test");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test name";
      Vendor newVendor = new Vendor(name, "test");

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
      [TestMethod]
    public void GetAll_ReturnsCategoryObjects_Category () 
    {
      //Arrange
      string name01 = "taco";
      string name02 = "corndog";
      Vendor newVendor1 = new Vendor (name01,"Tacostore");
      Vendor newVendor2 = new Vendor (name02,"corndog store");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      
      //Act
      List<Vendor> newResult = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual (newList, newResult);
    }
    [TestMethod]
    public void FindVendor_ReturnCorrectVendor_Vendor ()
    {
        //Arrange
        string name01 = "bobs cookhouse";
        string name02 = "sauage palace";
        Vendor newVendor1 = new Vendor(name01, "test");
        Vendor newVendor2 = new Vendor(name02, "test");
        //Act
        Vendor result = Vendor.Find(2);
        //Assert
        Assert.AreEqual(newVendor2, result);
    }
    
  }
}
