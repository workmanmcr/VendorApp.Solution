using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorApp.Models;

namespace VendorApp.Tests
{
    [TestClass]
    public class VendorTests 
    {
   
        [TestMethod]
       public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
        Vendor newVendor = new Vendor("test", "test");
        Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
    }
}
