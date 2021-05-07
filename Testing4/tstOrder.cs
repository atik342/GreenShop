using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        string CustomerID = "22";
        string OrderDetails = "this is your product";
        string Price = "300";
        string DateOrdered = DateTime.Now.Date.ToString();
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
            Int32 TestData = 100;
            AnOrder.Price = TestData;
            Assert.AreEqual(AnOrder.Price, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with this method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinLessOneOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string CustomerID = "";//this should trigger an error
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMIn()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string CustomerID = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string CustomerID = "aa";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string CustomerID = "aaaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string CustomerID = "aaaaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string CustomerID = "aaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string CustomerID = "aaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500,'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test data value
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test data value
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderedMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test data value
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test data value
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateOrderedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a variable to store the test data value
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //set the DateOrdered to a non data value
            string DateOrdered = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDetailsMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string OrderDetails = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDetailsMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string OrderDetails = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDetailsMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string OrderDetails = "aa";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDetailsMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string OrderDetails = "";
            OrderDetails = OrderDetails.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDetailsMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string OrderDetails = "";
            OrderDetails = OrderDetails.PadRight(50, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDetailsMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string OrderDetails = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDetailsMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string OrderDetails = "";
            OrderDetails = OrderDetails.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should fail
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Price = "a";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Price = "aa";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Price = "";
            Price = Price.PadRight(49, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Price = "";
            Price = Price.PadRight(50,'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Price = "";
            Price = Price.PadRight(51, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //this should pass
            string Price = "";
            Price = Price.PadRight(25, 'a');
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the orderid
            if (AnOrder.OrderID != 21)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Price
            if (AnOrder.Price != 210)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the customerid
            if (AnOrder.CustomerID != 12)
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDetailsFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the orderdetails
            if (AnOrder.OrderDetails != "this is your product")
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOrderedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with this method
            Int32 OrderID = 21;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the orderid
            if (AnOrder.DateOrdered != Convert.ToDateTime("10/10/2020"))
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestValidMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDetails, Price, DateOrdered);
        }
    }
}
