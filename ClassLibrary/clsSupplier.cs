using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        public string SupplierName { get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
        public DateTime DateAdded { get; set; }
        public int ContactNumber { get; set; }
        public string Address { get; set; }
        public bool OngoingContract { get; set; }
    }
}