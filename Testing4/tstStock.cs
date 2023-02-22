using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            // creates a new instance of the class
            clsStock AStock = new clsStock();
            // testing to see if the class exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void GameIdOK()
        {
            clsStock AStock = new clsStock();
            int TestData = 0;
            AStock.GameID = TestData;
            Assert.AreEqual(AStock.GameID, TestData);


        }
        [TestMethod]
        public void GameNameOK()
        {
            clsStock AStock = new clsStock();
            String TestData = "";
            AStock.GameName = TestData;
            Assert.AreEqual(AStock.GameName, TestData);
        }
        [TestMethod]
        public void GamePriceOK()
        {
            clsStock AStock = new clsStock();
            Double TestData = 10.1;
            AStock.GamePrice = TestData;
            Assert.AreEqual(AStock.GamePrice, TestData);
        }
        [TestMethod]
        public void AmountInStockOK()
        {
            clsStock AStock = new clsStock();
            int TestData = 0;
            AStock.AmountInStock = TestData;
            Assert.AreEqual(AStock.AmountInStock, TestData);
        }
        [TestMethod]
        public void GenreOK()
        {
            clsStock AStock = new clsStock();
            String TestData = "";
            AStock.Genre = TestData;
            Assert.AreEqual(AStock.Genre, TestData);
        }
        [TestMethod]
        public void ReleaseDateOK()
        {
            clsStock AStock = new clsStock();
            //DateTime TestData = ;

        }

    }

    
}
