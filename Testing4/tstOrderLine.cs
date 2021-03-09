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
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with this method
            Int32 OrderLineID = 12;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderLineIDFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderLineID = 12;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the orderid
            if (AnOrderLine.OrderLineID != 12)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderLineID = 12;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the orderid
            if (AnOrderLine.ProductID != 212)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderLineID = 12;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the orderid
            if (AnOrderLine.OrderID != 21)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductDetailsFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderLineID = 12;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the orderid
            if (AnOrderLine.ProductDetails != "this is your product")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductQuantityFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderLineID = 12;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the orderid
            if (AnOrderLine.ProductQuantity != 3)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestShippingStatusFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderLineID = 12;
            //invoke the method
            Found = AnOrderLine.Find(OrderLineID);
            //check the orderid
            if (AnOrderLine.ShippingStatus != true)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
