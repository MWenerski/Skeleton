using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStock
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
        public int AmountInStock { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Supplier { get; set; }
        public Boolean InStock { get; set; }
    }
}
