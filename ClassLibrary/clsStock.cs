using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStock
    {
        // 1. make private variable
        // 2. get - return privatge variable
        // 3. set - assign value to private variable
        //done for all get/set methods, same code - diffeent private variable names, not writing unnecessary comments
        private Int32 mID;
        public int GameID
        {
            get { return mID; }
            set { mID = value; }
        }
        private string mGameName;
        public string GameName
        {
            get { return mGameName; }
            set { mGameName = value; }
        }
        private double mGamePrice;
        public double GamePrice
        {
            get { return mGamePrice; }
            set { mGamePrice = value; }
        }

        private int mAmountInStock;
        public int AmountInStock
        {
            get { return mAmountInStock; }
            set { mAmountInStock = value; }
        }

        private string mGenre;
        public string Genre
        {
            get { return mGenre; }
            set { mGenre = value; }
        }

        private String mReleaseDate;
        public DateTime ReleaseDate
        {
            get { return DateTime.Parse(mReleaseDate); }
            set { mReleaseDate = value.ToString("dd/MM/yyyy"); }
        }

        private string mSupplier;
        public string Supplier
        {
            get { return mSupplier; }
            set { mSupplier = value; }
        }

        private Boolean mInStock;
        public Boolean InStock
        {
            get { return mInStock; }
            set { mInStock = value; }
        }

        public bool Find(int GameID) // find method that looks for a database entry by using game id, has hardcoded values for now
        {
            mID = 1;
            mGameName = "name";
            mGamePrice = 10.00;
            mAmountInStock = 1;
            mGenre = "action";
            mReleaseDate = new DateTime(2000, 01, 01).ToString("dd/MM/yyyy");
            mSupplier = "supplier";
            mInStock = true;
            return true;
        }

        public string Valid(string GameID, string GameName, string GamePrice, string AmountInStock, string Genre, string ReleaseDate, string Supplier, string InStock)
        {
            String Error = "";
            Int32 TempNum;

            try
            {
                TempNum = Convert.ToInt32(GameID);
                if (TempNum < 0)
                {
                    Error = Error + "The Game ID has to be larger than 0";
                }

            }
            catch (OverflowException)
            {
                Error = Error + "The Game ID is too large";
                
            }
            catch (FormatException)
            {
                Error = Error + "The Game ID is not a valid value";
            }
           
            /*
            if (GameName.Length == 0)
            {
                Error = Error + "The name of the game should not be blank";
            }
            if (GamePrice.Length == 0)
            {
                Error = Error + "The price of the game should not be blank";
            }
            if (AmountInStock.Length == 0)
            {
                Error = Error + "The amount in stock of the game should not be blank";
            }
            if (Genre.Length == 0)
            {
                Error = Error + "The genre of the game should not be blank";
            }
            if (Supplier.Length == 0)
            {
                Error = Error + "The supplier of the game should not be blank";
            }
            */

            // return any error messages
            return Error;
        }
    }
}
