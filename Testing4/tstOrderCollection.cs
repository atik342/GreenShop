using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrder);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 21;
            TestItem.OrderDetails = "this is your product";
            TestItem.CustomerID = 12;
            TestItem.Price = 210;
            TestItem.DateOrdered = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.OrderList, TestList);
        }
        /*[TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllOrder.Count = SomeCount;
            //test tp see that the two values are the same
            Assert.AreEqual(AllOrder.Count, SomeCount);
        }*/
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.OrderID = 21;
            TestOrder.OrderDetails = "this is your product";
            TestOrder.CustomerID = 12;
            TestOrder.Price = 210;
            TestOrder.DateOrdered = DateTime.Now.Date;
            //assign the data to the property
            AllOrder.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of the test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderID = 21;
            TestItem.OrderDetails = "this is your product";
            TestItem.CustomerID = 12;
            TestItem.Price = 210;
            TestItem.DateOrdered = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.Count, TestList.Count);
        }
        /*  [TestMethod]
          public void TwoRecordsPresent()
          {
              //create an instance of the class we want to create
              clsOrderCollection AllOrder = new clsOrderCollection();
              //test tp see that the two values are the same
              Assert.AreEqual(AllOrder.Count, 2);
          }*/
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 21;
            TestItem.OrderDetails = "this is your product";
            TestItem.CustomerID = 12;
            TestItem.Price = 210;
            TestItem.DateOrdered = DateTime.Now.Date;

            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 21;
            TestItem.OrderDetails = "this is your product";
            TestItem.CustomerID = 12;
            TestItem.Price = 210;
            TestItem.DateOrdered = DateTime.Now.Date;

            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify test data
            TestItem.OrderID = 22;
            TestItem.OrderDetails = "this is a product";
            TestItem.CustomerID = 13;
            TestItem.Price = 310;
            TestItem.DateOrdered = DateTime.Now.Date;
            //set the record based on the new test data
            AllOrder.ThisOrder = TestItem;
            //update the record
            AllOrder.Update();
            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrder.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            // var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderID = 21;
            TestItem.OrderDetails = "this is your product";
            TestItem.CustomerID = 12;
            TestItem.Price = 210;
            TestItem.DateOrdered = DateTime.Now.Date;

            //set ThisOrder to the test data
            AllOrder.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrder.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;

            //find the record
            AllOrder.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrder.Delete();
            //now find the record
            Boolean Found = AllOrder.ThisOrder.Find(PrimaryKey);
            //test to see the record was not found
            Assert.IsFalse(Found);
        }
         [TestMethod]
         public void ReportByCustomerIDMethodOK()
         {
             //create an instance of the class containing unfiltered results
             clsOrderCollection AllOrder = new clsOrderCollection();
             //create an instance of the filtered data
             clsOrderCollection FilteredOrder = new clsOrderCollection();
             //apply a blank string (should return all records);
             FilteredOrder.ReportByCustomerID(12);
             //test to see that the two values are the same
             Assert.AreEqual(AllOrder.Count, FilteredOrder.Count);
         }
        [TestMethod]
        public void ReportByCustomerIDNoneFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //apply a post code that doesn't exist
            FilteredOrder.ReportByCustomerID(0);
            //test to see that there are no records
            Assert.AreEqual(0, FilteredOrder.Count);
        }
        [TestMethod]
        public void ReportByCustomerIDDataFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a customer id that doesn't exist
            FilteredOrder.ReportByCustomerID(12);
            //check that the correct number of records are found
            if(FilteredOrder.Count ==2)
            {
                //check that the first record is ID 105
                if(FilteredOrder.OrderList[0].OrderID != 105)
                {
                    OK = false;
                }
                //check that the first record is ID 106
                if(FilteredOrder.OrderList[1].OrderID != 106)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsFalse(OK);
        }
    }
}
