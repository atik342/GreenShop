using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void ActiveOrdersPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.ActiveOrders = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.ActiveOrders, TestData);
        }

        [TestMethod]
        public void dateAccCreatedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.dateAccCreated = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.dateAccCreated, TestData);
        }

        [TestMethod]
        public void FullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "Full Name";
            //assign the data to the property
            ACustomer.FullName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.FullName, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "B62 0DN";
            //assign the data to the property
            ACustomer.PostCode = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "A Road";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);
        }

        [TestMethod]
        public void CustIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.CustID = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.CustID, TestData);
        }

        [TestMethod]
        public void MobileNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "XXXXXXXXXXX";
            //assign the data to the property
            ACustomer.MobileNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.MobileNo, TestData);
        }

    }

}

