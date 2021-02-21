using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        
        [TestMethod]
        public void DateOrderedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateOrdered = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Int32 TestData = 145;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }
        
        [TestMethod]
        public void OrderDetailsPropertiesOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "3 items in the order";
            AnOrder.OrderDetails = TestData;
            Assert.AreEqual(AnOrder.OrderDetails, TestData);
        }
      
        [TestMethod]
        public void PricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Decimal TestData = 100;
            AnOrder.Price = TestData;
            Assert.AreEqual(AnOrder.Price, TestData);
        }
    }
}
