using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Assert.IsNotNull(AnOrderLine);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderID = TestData;
            Assert.AreEqual(AnOrderLine.OrderID, TestData);
        }
        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 2;
            AnOrderLine.ProductQuantity = TestData;
            Assert.AreEqual(AnOrderLine.ProductQuantity, TestData);
        }
        [TestMethod]
        public void ProductDetailsPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            string TestData = "this is a test product";
            AnOrderLine.ProductDetails = TestData;
            Assert.AreEqual(AnOrderLine.ProductDetails, TestData);
        }
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1231;
            AnOrderLine.ProductID = TestData;
            Assert.AreEqual(AnOrderLine.ProductID, TestData);
        }
        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderLineID = TestData;
            Assert.AreEqual(AnOrderLine.OrderLineID, TestData);
        }
        [TestMethod]
        public void ShippingStatusPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean TestData = true;
            AnOrderLine.ShippingStatus = TestData;
            Assert.AreEqual(AnOrderLine.ShippingStatus, TestData);
        }
    }
}
