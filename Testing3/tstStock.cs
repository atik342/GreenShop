﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);

        }
    }
}
