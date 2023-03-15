using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public clsOrder()
        {
        }

        public bool Active { get; set; }

        public string OrderID { get; set; }
        public DateTime DateAdded { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public string GameName { get; set; }
        public bool InStock { get; set; }
        public DateTime OrderDate { get; set; }
        public double GamePrice { get; set; }
        public double TotalPayable { get; set; }
        public int CustomerID { get; set; }

        public bool Find(int testNo)
        {
            return true;
        }
    }
}