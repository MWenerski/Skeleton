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
            String TestData = new DateTime(2022, 5, 10).ToString("dd/MM/yyyy"); 
            AStock.ReleaseDate = DateTime.Parse(TestData);
            Assert.AreEqual(AStock.ReleaseDate.ToString("dd/MM/yyyy"), TestData);
        }
        [TestMethod]
         public void FindOK()
         {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 GameID = 1;
            Found = AStock.Find(GameID);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestGameIDFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameID = 1;
            Found = AStock.Find(GameID);
            if (AStock.GameID != 1) OK = false;
            Assert.IsTrue(OK);

        }
        public void TestGameName()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameID = 1;
            Found = AStock.Find(GameID);
            if (AStock.GameName != "name") OK = false;
            Assert.IsTrue(OK);

        }
        public void TestGamePrice()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameID = 1;
            Found = AStock.Find(GameID);
            if (AStock.GamePrice != 10.00) OK = false;
            Assert.IsTrue(OK);

        }
        public void TestAmountInStock()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameID = 1;
            Found = AStock.Find(GameID);
            if (AStock.AmountInStock != 1) OK = false;
            Assert.IsTrue(OK);

        }
        public void TestGenre()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameID = 1;
            Found = AStock.Find(GameID);
            if (AStock.Genre != "action") OK = false;
            Assert.IsTrue(OK);

        }
        public void TestReleaseDate()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameID = 1;
            Found = AStock.Find(GameID);
            if (AStock.ReleaseDate != new DateTime(0000, 00, 00)) OK = false;
            Assert.IsTrue(OK);

        }
        public void TestSupplier()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameID = 1;
            Found = AStock.Find(GameID);
            if (AStock.Supplier != "supplier") OK = false;
            Assert.IsTrue(OK);

        }
        public void TestInStock()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 GameID = 1;
            Found = AStock.Find(GameID);
            if (AStock.InStock != true) OK = false;
            Assert.IsTrue(OK);

        }






        ///
        /// ///////////////////////
        /// 


        //good test data
        //create some test data to pass to the method
           string GameID = "1";
           string GameName = "abc";
           string GamePrice = "10.00";
           string AmountInStock = "1";
           string Genre = "Action";
           string ReleaseDate = new DateTime(2002,09,11).ToString();
           string Supplier = "Game Co.";
           string InStock = "true";
          ///

        public string Valid(string GameID, string GameName, string GamePrice, string AmountInStock, string Genre, string ReleaseDate, string Supplier, string InStock)
        {
            // create a string variable to store the error
            String Error = "";
            // if the GameID is blank
            if (GameID.Length == 0)
            {
                Error = Error + "The ID of the game should not be blank";
            }
            // return error messages
            return Error;
        }





        public void GameIDExtremeMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string GameID = "";
            Error = Stock.Valid(GameID, GameName, GamePrice, AmountInStock, Genre, ReleaseDate, Supplier, InStock);
            Assert.AreNotEqual(Error, "");
        }

        public void GameIDMin()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string GameID = "a";
            Error = Stock.Valid(GameID, GameName, GamePrice, AmountInStock, Genre, ReleaseDate, Supplier, InStock);
            Assert.AreNotEqual(Error, "");
        }

        public void GameIDMinadd1()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string GameID = "a";
            Error = Stock.Valid(GameID, GameName, GamePrice, AmountInStock, Genre, ReleaseDate, Supplier, InStock);
            Assert.AreNotEqual(Error, "");
        }

        public void GameIDMaxmin1()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string GameID = "aaaaaaaaa";
            Error = Stock.Valid(GameID, GameName, GamePrice, AmountInStock, Genre, ReleaseDate, Supplier, InStock);
            Assert.AreNotEqual(Error, "");
        }

        public void GameIDMax()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string GameID = "aaaaaaaaaa";
            Error = Stock.Valid(GameID, GameName, GamePrice, AmountInStock, Genre, ReleaseDate, Supplier, InStock);
            Assert.AreNotEqual(Error, "");
        }

        public void GameIDMaxadd1()
        {
            clsStock Stock = new clsStock();
            String Error = "";
            string GameID = "aaaaaaaaaaa";
            Error = Stock.Valid(GameID, GameName, GamePrice, AmountInStock, Genre, ReleaseDate, Supplier, InStock);
            Assert.AreNotEqual(Error, "");
        }

    }

    
   

}
